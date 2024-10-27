using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene6LunaMovement : MonoBehaviour
{
    public float moveSpeed = 5f;    // Movement speed of the player

    [SerializeField] private GameObject LunaWalk;
    [SerializeField] private GameObject Lunacrouch;
    [SerializeField]private Animator animator;
    [SerializeField] private Animator CrouchAnimator;

    private bool Run;
    private bool Crouch;

    private Rigidbody2D rb;         // Reference to the player's Rigidbody2D component
    private Vector2 movement;       // Stores the movement input

    void Start()
    {
        Lunacrouch.SetActive(false);
        LunaWalk.SetActive(true);
        // Get the Rigidbody2D component attached to the player
        rb = GetComponent<Rigidbody2D>();
        Run = animator.GetBool("Run");
        Crouch = CrouchAnimator.GetBool("Crouch");
    }

    void Update()
    {
        Run = animator.GetBool("Run");
        Crouch = CrouchAnimator.GetBool("Crouch");
        // Get horizontal and vertical input (WASD or arrow keys)
        movement.x = Input.GetAxisRaw("Horizontal");  // Left/Right input
        movement.y = 0;    // Up/Down input

        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            transform.localScale = new Vector3(2, transform.localScale.y, transform.localScale.z);
        }
        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            transform.localScale = new Vector3(-2, transform.localScale.y, transform.localScale.z);
        }
        if(Input.GetKeyDown(KeyCode.C))
        {
            Lunacrouch.SetActive(true);
            CrouchAnimator.SetBool("Crouch", true);
            LunaWalk.SetActive(false);
        }
        if (Input.GetKeyUp(KeyCode.C))
        {
            Lunacrouch.SetActive(false);
            CrouchAnimator.SetBool("Crouch",false);
            LunaWalk.SetActive(true);
        }
        if(Run)
        {
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
            {
                animator.SetBool("Running", true);
            }
            else
            {
                animator.SetBool("Running", false);
            }
        }
        else if (Crouch)
        {
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
            {
                CrouchAnimator.SetBool("Crawling", true);
            }
            else
            {
                CrouchAnimator.SetBool("Crawling", false);
            }
        }
        else
        {
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
            {
                animator.SetBool("Walking", true);
            }
            else
            {
                animator.SetBool("Walking", false);
            }
        }
        
    }

    void FixedUpdate()
    {
        // Move the player based on input
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
