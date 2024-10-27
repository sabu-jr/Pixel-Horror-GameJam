using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene3RufusFollow : MonoBehaviour
{
    public Transform player;          // Reference to the player's transform
    public float followDistance = 2f; // The distance the NPC will keep from the player
    public float moveSpeed = 4f;      // The speed at which the NPC moves towards the player

    [SerializeField] Animator animator;

    // Update is called once per frame
    void Update()
    {
        // Check the distance between the NPC and the player
        float distanceToPlayer = Vector2.Distance(transform.position, player.position);

        // If the distance is greater than the followDistance, move towards the player
        if (distanceToPlayer > followDistance)
        {
            // Determine if the player is to the right or left of the NPC
            if (player.position.x > transform.position.x)
            {
                // Player is to the right, so face right
                transform.localScale = new Vector3(2, transform.localScale.y, transform.localScale.z);
            }
            else
            {
                // Player is to the left, so face left
                transform.localScale = new Vector3(-2, transform.localScale.y, transform.localScale.z);
            }

            // Move the NPC towards the player's position
            transform.position = Vector2.MoveTowards(transform.position, player.position, moveSpeed * Time.deltaTime);

        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {

            // Set animator parameter to indicate movement
            animator.SetBool("Walking", true);
        }
        else
        {
            // Set animator parameter to indicate idle
            animator.SetBool("Walking", false);
        }
    }

    // Trigger method to detect when player enters the trigger zone
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the object that entered the trigger is the player
        if (other.CompareTag("Player"))
        {
            // Start following the player when they enter the trigger zone
            //shouldFollow = true;
        }
    }
}