using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
	[SerializeField] Type type;
	[SerializeField] List<Sprite> tiles;

	public Type Type
	{
		get
		{
			return type;
		}

		set
        {
			type = value;
            SetSprite();
        }
	}

    private void SetSprite()
    {
        switch (type)
        {
            case Type.red:
                GetComponent<SpriteRenderer>().sprite = tiles[0];
                break;
            case Type.yellow:
                GetComponent<SpriteRenderer>().sprite = tiles[1];
                break;
            case Type.green:
                GetComponent<SpriteRenderer>().sprite = tiles[2];
                break;
            case Type.pink:
                GetComponent<SpriteRenderer>().sprite = tiles[3];
                break;
            case Type.blue:
                GetComponent<SpriteRenderer>().sprite = tiles[4];
                break;
            case Type.purple:
                GetComponent<SpriteRenderer>().sprite = tiles[5];
                break;
            default:
                GetComponent<SpriteRenderer>().sprite = tiles[6];
                break;
        }
    }
}
