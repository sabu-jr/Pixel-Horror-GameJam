using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Scene2FlorenceAppears : MonoBehaviour
{
    [SerializeField] SpriteRenderer SpriteRenderer;
    [SerializeField] GameObject UICanvas;
    // Start is called before the first frame update
    void Start()
    {
        UICanvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            SpriteRenderer.enabled = true;
            UICanvas.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Collider2D selfCollidor = GetComponent<Collider2D>();
            selfCollidor.enabled = false;
        }
    }
}
