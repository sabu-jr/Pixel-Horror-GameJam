using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene2CameraUpperMove : MonoBehaviour
{
    [SerializeField] private Transform cameraPos;

    private void Start()
    {
        cameraPos.transform.position = new Vector3(0, 0, -10);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            cameraPos.transform.position = new Vector3(0, 10.00f,-10);
        }
    }
}
