using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class Scene2FlorenceFollowLuna : MonoBehaviour
{
    public RuleTile.TilingRuleOutput.Transform player;          // Reference to the player's transform
    public float followDistance = 2f; // The distance the NPC will keep from the player
    public float moveSpeed = 3f;      // The speed at which the NPC moves towards the player
    private bool shouldFollow = false; // Whether the NPC should follow the player

    // Update is called once per frame
    void Update()
    {
        // Only follow the player if the trigger has been activated
        if (shouldFollow)
        {
            // Check the distance between the NPC and the player
            float distanceToPlayer = Vector2.Distance(transform.position, player.position);

            // If the distance is greater than the followDistance, move towards the player
            if (distanceToPlayer > followDistance)
            {
                // Move the NPC towards the player's position
                transform.position = Vector2.MoveTowards(transform.position, player.position, moveSpeed * Time.deltaTime);
            }
        }
    }

    // Trigger method to detect when player enters the trigger zone
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the object that entered the trigger is the player
        if (other.CompareTag("Player"))
        {
            // Start following the player when they enter the trigger zone
            shouldFollow = true;
        }
    }
}
