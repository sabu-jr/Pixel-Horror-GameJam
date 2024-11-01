using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene4DialogueTrigger : MonoBehaviour
{
    [SerializeField] GameObject DlgCanvas;

    private bool Triggered;
    void Start()
    {
        DlgCanvas.SetActive(false);
        Triggered = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && !Triggered)
        {
            DlgCanvas.SetActive(true);
            Triggered = true;
        }
    }
}
