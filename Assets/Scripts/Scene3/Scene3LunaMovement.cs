using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene3LunaMovement : MonoBehaviour
{
    public float moveSpeed = 5f;    // Movement speed of the player
    private Rigidbody2D rb;         // Reference to the player's Rigidbody2D component
    private Vector2 movement;       // Stores the movement input

    void Start()
    {
        // Get the Rigidbody2D component attached to the player
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Get horizontal and vertical input (WASD or arrow keys)
        movement.x = Input.GetAxisRaw("Horizontal");  // Left/Right input
        movement.y = 0;    // Up/Down input

        if (Input.GetAxisRaw("Horizontal")>0)
        {
            transform.localScale = new Vector3(2, transform.localScale.y, transform.localScale.z);
        }
        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            transform.localScale = new Vector3(-2, transform.localScale.y, transform.localScale.z);
        }
    }

    void FixedUpdate()
    {
        // Move the player based on input
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
