using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene6CameraMovement : MonoBehaviour
{
    [SerializeField] Transform CameraTransform;

    private void Start()
    {
        CameraTransform.position = new Vector3(0,0,-10f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "CameraBoundRight" && CameraTransform.position.x< 74f)
        {
            //move forward
            CameraTransform.position = new Vector3(CameraTransform.position.x + 13.6f, 0, -10f);
        }
        if (collision.gameObject.name == "CameraBoundLeft" && CameraTransform.position.x >0)
        {
            //move Back
            CameraTransform.position = new Vector3(CameraTransform.position.x - 13.6f, 0, -10f);
        }
    }
}
