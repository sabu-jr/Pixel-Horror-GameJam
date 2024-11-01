using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraForwardMove : MonoBehaviour
{
    [SerializeField] private Transform cameraTransform;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            cameraTransform.transform.position = new Vector3(14.21f, 0,-10);
        }
    }
}
