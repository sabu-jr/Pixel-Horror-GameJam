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

    public Animator animator;
    public AudioSource audioSource;
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
        // Set animator parameters based on movement direction
        if (Input.GetKey(KeyCode.W)) // Moving up
        {
            animator.SetBool("WalkUp", true);
            animator.SetBool("WalkDown", false);
        }
        else if (Input.GetKey(KeyCode.S)) // Moving down
        {
            animator.SetBool("WalkUp", false);
            animator.SetBool("WalkDown", true);
        }
        else // Not moving vertically
        {
            animator.SetBool("WalkUp", false);
            animator.SetBool("WalkDown", false);
        }

        // Play footstep audio if character is moving
        if ((movement.x != 0 || movement.y != 0) && !audioSource.isPlaying)
        {
            audioSource.Play(); // Start playing the footstep audio
        }
        else if (movement.x == 0 && movement.y == 0 && audioSource.isPlaying)
        {
            audioSource.Pause(); // Pause the audio when character stops moving
        }
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
