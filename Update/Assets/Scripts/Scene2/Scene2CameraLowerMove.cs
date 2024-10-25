using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene2CameraLowerMove : MonoBehaviour
{
    [SerializeField] private Transform cameraPos;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            cameraPos.transform.position = new Vector3(0,0,-10);
        }
    }
}
