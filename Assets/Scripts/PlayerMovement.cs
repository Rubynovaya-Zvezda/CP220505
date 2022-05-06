using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 1;
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.Space))
            rb.AddForce(new Vector2(0, 100f), ForceMode2D.Impulse);
        if(Input.GetKey(KeyCode.A))
            rb.AddForce(new Vector2(-30f, 0), ForceMode2D.Impulse);
        if(Input.GetKey(KeyCode.D))
            rb.AddForce(new Vector2(30f, 0), ForceMode2D.Impulse);
    }
}
