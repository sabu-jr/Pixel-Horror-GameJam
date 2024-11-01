using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene3DoorTriggers : MonoBehaviour
{
    [SerializeField] Canvas DoorDialogueCanvas;
    // Start is called before the first frame update

    private bool triggered;
    void Start()
    {
        triggered = false;
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && !triggered)
        {
            triggered=true;
            DoorDialogueCanvas.gameObject.SetActive(true);
        }
    }
}
