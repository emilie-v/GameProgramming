using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
	[SerializeField] Type type;
	[SerializeField] List<Sprite> tiles;
    [SerializeField] List<Color> colours;

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
                GetComponent<SpriteRenderer>().color = colours[0];
                break;

            case Type.yellow:
                GetComponent<SpriteRenderer>().sprite = tiles[1];
                GetComponent<SpriteRenderer>().color = colours[1];
                break;

            case Type.green:
                GetComponent<SpriteRenderer>().sprite = tiles[2];
                GetComponent<SpriteRenderer>().color = colours[2];
                break;

            case Type.pink:
                GetComponent<SpriteRenderer>().sprite = tiles[3];
                GetComponent<SpriteRenderer>().color = colours[3];
                break;

            case Type.blue:
                GetComponent<SpriteRenderer>().sprite = tiles[4];
                GetComponent<SpriteRenderer>().color = colours[4];
                break;

            case Type.purple:
                GetComponent<SpriteRenderer>().sprite = tiles[5];
                GetComponent<SpriteRenderer>().color = colours[5];
                break;

            default:
                GetComponent<SpriteRenderer>().sprite = tiles[6];
                GetComponent<SpriteRenderer>().color = colours[6];
                break;
        }
    }
}
