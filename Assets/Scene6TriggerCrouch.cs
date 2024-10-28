using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Scene6TriggerCrouch : MonoBehaviour
{
    [SerializeField] private GameObject Dialoguecanvas;
    [SerializeField] private GameObject InfoCanvas;
    [SerializeField] private TMP_Text InfoText;

    private bool triggered;
    // Start is called before the first frame update
    void Start()
    {
        Dialoguecanvas.SetActive(false);
        InfoCanvas.SetActive(false);
        triggered = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && !triggered)
        {
            triggered = true;
            Dialoguecanvas.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        InfoCanvas.SetActive(false);
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        InfoText.text = "Press C to Crouch";
        InfoCanvas.SetActive(true);
    }
}
