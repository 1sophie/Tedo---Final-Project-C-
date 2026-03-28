using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 10f;
    public float jumpForce = 12f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        {
            float move = Input.GetAxis("Horizontal");
            rb.velocity = new Vector2(move * speed, rb.velocity.y);

            // Jumping
            if (Input.GetKeyDown(KeyCode.Space))
            {
                // Change 0.05f to 0.01f to be more strict
                // This stops you from jumping while already in the air
                if (Mathf.Abs(rb.velocity.y) < 0.01f)
                {
                    rb.velocity = new Vector2(rb.velocity.x, 0);
                    rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
                }
            }
        }
    }
}