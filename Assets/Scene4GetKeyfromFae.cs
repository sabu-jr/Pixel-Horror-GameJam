using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene4GetKeyfromFae : MonoBehaviour
{
    public GameObject keyPrefab; // Reference to the key prefab

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Check if the lamp collides with the player or the floor
        if (collision.CompareTag("Player") || collision.CompareTag("Floor"))
        {
            SpawnKey();
        }
    }

    private void SpawnKey()
    {
        // Instantiate the key prefab at the lamp's position
        Instantiate(keyPrefab, transform.position, Quaternion.identity);

        // Optionally, you can destroy the lamp after spawning the key
        Destroy(gameObject);
    }
}
