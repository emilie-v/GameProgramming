using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [Header("Node List")]
    [SerializeField] List<Node> nodes = new List<Node>();
    [Header("Player Stuff")]
    [SerializeField] List<Player> players = new List<Player>();
    [SerializeField] Button diceButton;

    int playerIndex = 0;

    Player currentPlayer;

    void Start()
    {
        currentPlayer = players[0];

        foreach (var player in players)
        {
            player.transform.position = nodes[0].transform.position;
        }

        SetNodeTypes();
    }

    private void SetNodeTypes()
    {
        int index = 0;

        for (int i = 0; i < nodes.Count; i++)
        {

            if (index > 6)
            {
                index = 1;
            }

            if (i == 0)
            {
                nodes[i].Type = Type.start;
            }

            else if (i == nodes.Count - 1)
            {
                nodes[i].Type = Type.finish;
            }

            else if (index % 6 == 0)
            {
                nodes[i].Type = Type.purple;
            }

            else if (index % 5 == 0)
            {
                nodes[i].Type = Type.blue;
            }

            else if (index % 4 == 0)
            {
                nodes[i].Type = Type.pink;
            }

            else if (index % 3 == 0)
            {
                nodes[i].Type = Type.green;
            }

            else if (index % 2 == 0)
            {
                nodes[i].Type = Type.yellow;
            }

            else if (index % 1 == 0)
            {
                nodes[i].Type = Type.red;
            }

            index++;
        }
    }

    public void RollDice()
    {
        List<Node> path = new List<Node>();


        Type targetType = Type.red;
        int random = Random.Range(0, 6);

        switch (random)
        {
            case 0:
                targetType = Type.red;
                break;

            case 1:
                targetType = Type.yellow;
                break;

            case 2:
                targetType = Type.green;
                break;

            case 3:
                targetType = Type.pink;
                break;

            case 4:
                targetType = Type.blue;
                break;

            case 5:
                targetType = Type.purple;
                break;


            default:
                Debug.LogError("outside of die range");
                break;
        }

        Debug.Log(targetType);

        for (int i = currentPlayer.CurrentTile + 1; i < nodes.Count; i++)
        {           
            path.Add(nodes[i]);

            if (nodes[i].Type == targetType)
            {
                break;
            }

            if (nodes[i].Type == Type.finish)
            {
                break;
            }
        }

        diceButton.interactable = false;
        currentPlayer.MoveToTile(path);
    }

    public void ChangeCurrentPlayer()
    {
        playerIndex++;

        if (playerIndex >= players.Count)
        {
            playerIndex = 0;
        }

        currentPlayer = players[playerIndex];

        diceButton.interactable = true;
    }
}
