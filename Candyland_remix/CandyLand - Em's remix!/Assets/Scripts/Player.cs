using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
	[SerializeField] float speed = 5f;
	[SerializeField] float waitTime = 0.5f;
	int currentTile = 0;

	Game gameManager;

    private void Start()
    {
		gameManager = FindObjectOfType<Game>();
    }

    public int CurrentTile
    {
        get
        {
			return currentTile;
        }
    }

	List<Node> path = new List<Node>();

	public void MoveToTile(List<Node> path)
	{
		this.path = new List<Node>(path);
		StartCoroutine(MovePlayer(0));
	}

	IEnumerator MovePlayer(int index)
	{
		while (index < path.Count)
		{
			Vector3 targetPos = path[index].transform.position;
			transform.position = Vector3.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

			if (transform.position == targetPos)
			{
                if (path[index].Type == Type.finish)
                {
					Debug.Log(name + " has won!");
                }

				yield return new WaitForSeconds(waitTime);

				index++;
				currentTile++;

				if (index >= path.Count)
				{
					gameManager.ChangeCurrentPlayer();
				}
			}
		}
	}
}