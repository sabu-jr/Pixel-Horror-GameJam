using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene2PlayerMovement : MonoBehaviour
{
    private float Hmove;
    private float Vmove;

    public float moveSpeed = 5f;    // Speed of the player movement
    private Rigidbody2D rb;
    private SpriteRenderer spriteRenderer;
    Vector2 movement;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal"); 
        movement.y = Input.GetAxisRaw("Vertical");
    }
    void FixedUpdate()
    {
        // Move the player using Rigidbody2D
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);

        if (movement.x < 0)
        {
            // Moving left, flip the sprite by scaling negatively on the X-axis
            spriteRenderer.flipX = true;
        }
        else if (movement.x > 0)
        {
            // Moving right, reset the flip
            spriteRenderer.flipX = false;
        }
    }
}
