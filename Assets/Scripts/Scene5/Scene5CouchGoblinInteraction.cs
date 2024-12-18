using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene5CouchGoblinInteraction : MonoBehaviour
{
    [SerializeField] GameObject dialogueCanvas;
    // Start is called before the first frame update
    void Start()
    {
        dialogueCanvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            dialogueCanvas.SetActive(true);
        }
    }
}
