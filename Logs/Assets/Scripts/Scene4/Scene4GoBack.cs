using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Scene4GoBack : MonoBehaviour
{
    [SerializeField] private Canvas canvas;
    [SerializeField]private TMP_Text text;

    private void Start()
    {
        canvas.gameObject.SetActive(false);
        text.text = "Press E to take the stairs";
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            canvas.gameObject.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            canvas.gameObject.SetActive(false);
        }
    }
}
