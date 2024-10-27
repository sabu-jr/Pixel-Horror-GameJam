using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene3DlgTrigger : MonoBehaviour
{
    [SerializeField] GameObject DlgCanvas;
    // Start is called before the first frame update
    void Start()
    {
        DlgCanvas.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            DlgCanvas.SetActive(true);
        }
    }
}
