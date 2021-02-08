﻿using UnityEngine;

public class RoomsAndHallwaysGenerator : TileMapGeneratorTemplate
{
	public int numberOfRooms = 3;

	[Header("Room Settings")]
	public int roomMinHeight = 4;
	public int roomMaxHeight = 10;
	public int roomMinWidth = 4;
	public int roomMaxWidth = 14;

	public int corridorWidth = 3;

	int[,] newMap;

	public override void InitStartPos()
	{
		//Generate starting state
		startPos = new Vector3Int(Random.Range(0, width), Random.Range(0, height), 0);

		startPos = ClampVector(startPos, new Vector2Int(roomMaxWidth / 2, roomMaxHeight / 2));

		//Get the world position of our start tile position.
		GameObject.FindGameObjectWithTag("Player").transform.position = map.CellToWorld(new Vector3Int(-startPos.x + width / 2, -startPos.y + height / 2, 0));
	}

	public override int[,] GenerateTilePositions(int[,] oldMap)
	{
		newMap = oldMap;

		int newRoomWidth = Random.Range(roomMinWidth, roomMaxWidth);
		int newRoomHeight = Random.Range(roomMinHeight, roomMaxHeight);
		GenerateRoom(startPos, newRoomWidth, newRoomHeight);

		int count;
		do
		{
			int tries = 0;
			for (int i = 0; i < numberOfRooms; i++)
			{
				var oldPos = startPos;

				newRoomWidth = Random.Range(roomMinWidth, roomMaxWidth);
				newRoomHeight = Random.Range(roomMinHeight, roomMaxHeight);

				int offset = Random.Range(0, 2);
				do
				{
					int dir = (Random.Range(0, 2) * 2 - 1);
					if ((tries + offset) % 2 == 0)
					{
						startPos.x += dir * Random.Range(newRoomWidth + 1, newRoomWidth * 2);
						startPos = ClampVector(startPos, new Vector2Int(roomMaxWidth / 2, roomMaxHeight / 2));

						GenerateRoom((oldPos + startPos) / 2, Mathf.Abs(Mathf.Abs(startPos.x) - Mathf.Abs(oldPos.x)), corridorWidth);
					}
					else
					{
						startPos.y += dir * Random.Range(newRoomHeight + 1, newRoomHeight * 2);
						startPos = ClampVector(startPos, new Vector2Int(roomMaxWidth / 2, roomMaxHeight / 2));

						GenerateRoom((oldPos + startPos) / 2, corridorWidth, Mathf.Abs(Mathf.Abs(startPos.y) - Mathf.Abs(oldPos.y)));
					}
					tries++;
				} while (newMap[startPos.x, startPos.y] == 1 && tries < 50);

				GenerateRoom(startPos, newRoomWidth, newRoomHeight);
			}

			count = 0;
			for (int x = 0; x < width; x++)
			{
				for (int y = 0; y < height; y++)
				{
					if (newMap[x, y] == 1)
					{
						count++;
					}
				}
			}
			if (tries >= 50)
			{
				break;
			}

		} while (count < 1500);

		return newMap;
	}

	private void GenerateRoom(Vector3Int startPos, int roomWidth, int roomHeight)
	{
		int x = startPos.x;
		int y = startPos.y;

		Vector2 noiseOffset = new Vector2(Random.Range(0, 1f), Random.Range(0, 1f));

		for (int i = 0; i < roomWidth; i++)
		{
			float value = Mathf.PerlinNoise(i * 0.05f + noiseOffset.x, i * 0.05f + noiseOffset.y);
			int yOffset = Mathf.RoundToInt(value * 10) - 4;

			for (int j = 0; j < roomHeight; j++)
			{
				var newPos = new Vector3Int();
				newPos.x = x + i - roomWidth / 2;
				newPos.y = y + j - roomHeight / 2 - yOffset;
				newPos = ClampVector(newPos);

				newMap[newPos.x, newPos.y] = 1;
			}
		}
	}
}