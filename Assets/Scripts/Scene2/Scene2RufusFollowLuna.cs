using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene2RufusFollowLuna : MonoBehaviour
{
    public Transform player;          // Reference to the player's transform
    public float followDistance = 4f; // The distance the NPC will keep from the player
    public float moveSpeed = 5f;      // The speed at which the NPC moves towards the player
    

    // Update is called once per frame
    void Update()
    {
        // Only follow the player if the trigger has been activated
       
            // Check the distance between the NPC and the player
            float distanceToPlayer = Vector2.Distance(transform.position, player.position);

            // If the distance is greater than the followDistance, move towards the player
            if (distanceToPlayer > followDistance)
            {
                // Move the NPC towards the player's position
                transform.position = Vector2.MoveTowards(transform.position, player.position, moveSpeed * Time.deltaTime);
            }
    }

    // Trigger method to detect when player enters the trigger zone

}
