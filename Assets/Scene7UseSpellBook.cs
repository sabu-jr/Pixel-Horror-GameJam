using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene7UseSpellBook : MonoBehaviour
{
    [SerializeField] GameObject infoCanvas;
    // Start is called before the first frame update
    void Start()
    {
        infoCanvas.SetActive(false);
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        infoCanvas.SetActive(true);
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        infoCanvas.SetActive(false);
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("Book used");
            }
        }
    }
}
