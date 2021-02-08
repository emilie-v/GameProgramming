using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerKeyboard : MonoBehaviour
{
    PlayerMovement pm;
    void Start()
    {
        pm = GetComponent<PlayerMovement>();
    }

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        var move = new Vector3(x, y, 0);

        pm.MovePlayer(move.normalized);
    }
}
