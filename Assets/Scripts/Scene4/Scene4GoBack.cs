using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene4GoBack : MonoBehaviour
{
    [SerializeField] private Canvas canvas;

    private void Start()
    {
        canvas.gameObject.SetActive(false);
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
