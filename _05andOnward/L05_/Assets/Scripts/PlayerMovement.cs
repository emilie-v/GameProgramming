using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5;
    Rigidbody2D rb2d;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

 public void MovePlayer (Vector3 movement)
    {
        movement = movement.normalized;

        if (movement.sqrMagnitude > 0.01f)
        {
            transform.up = movement;
            transform.eulerAngles = new Vector3(0, 0, transform.eulerAngles.z);
            //transform.Translate(movement * speed * Time.deltaTime);

            rb2d.AddForce(transform.up * speed);
        }
        
    }
}
