using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBackwardMove : MonoBehaviour
{
    [SerializeField] private Transform cameraTransform;
 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            cameraTransform.transform.position = new Vector3(0, 0, -10);
        }
    }
}
