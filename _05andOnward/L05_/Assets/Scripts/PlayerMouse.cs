using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMouse : MonoBehaviour
{
    PlayerMovement pm;

    void Start()
    {
        pm = GetComponent<PlayerMovement>();
    }

    void Update()
    {
        Vector3 move = Vector3.zero;

        if (Input.GetMouseButton(0))
        {
            Vector3 mouse = Input.mousePosition;
            move = mouse - Camera.main.WorldToScreenPoint(transform.position);
            move = move.normalized;
        }
        pm.MovePlayer(move);
    }
}
