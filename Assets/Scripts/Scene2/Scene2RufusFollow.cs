using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene2RufusFollow : MonoBehaviour
{
    public Transform player;          // Reference to the player's transform
    public float followDistance = 1f; // The distance the NPC will keep from the player
    public float moveSpeed = 4f;      // The speed at which the NPC moves towards the player
    private bool shouldFollow = true; // Whether the NPC should follow the player

    private Vector2 lastPosition;     // Track the last position to determine direction

    // Start is called before the first frame update
    void Start()
    {
        lastPosition = transform.position;
    }

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

                // Calculate direction of movement
                Vector2 direction = (Vector2)transform.position - lastPosition;

                // Update last position
                lastPosition = transform.position;
            }
        }
    }
}
