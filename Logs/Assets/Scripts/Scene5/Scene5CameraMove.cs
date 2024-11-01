using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene5CameraMove : MonoBehaviour
{
    [SerializeField] Transform CameraTransform;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "CameraBoundRight")
        {
            //move forward
            CameraTransform.position = new Vector3(13.6f, 0, -10f);
        }
        if (collision.gameObject.name == "CameraBoundLeft")
        {
            //move Back
            CameraTransform.position = new Vector3(0, 0, -10f);
        }
    }
}
