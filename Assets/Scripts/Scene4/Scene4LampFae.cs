using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene4LampFae : MonoBehaviour
{
    public GameObject flyingLampFaePrefab; // Reference to the flying lamp fae prefab
    public GameObject lampPrefab;           // Reference to the lamp prefab
    public float dropOffset = 0.5f;        // Offset for the dropped lamp's position

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Check if the collider belongs to the player
        if (collision.CompareTag("Player"))
        {
            DropLampAndTransform();
        }
    }

    private void DropLampAndTransform()
    {
        // Instantiate the lamp at the current position with an offset
        Vector3 dropPosition = transform.position + Vector3.down * dropOffset;
        Instantiate(lampPrefab, dropPosition, Quaternion.identity);

        // Replace the current lamp fae with the flying lamp fae
        Instantiate(flyingLampFaePrefab, transform.position, Quaternion.identity);

        // Destroy the original lamp fae object
        Destroy(gameObject);
    }
}
