using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene3DlgTrigger : MonoBehaviour
{
    [SerializeField] GameObject DlgCanvas;

    private bool triggerd;
    // Start is called before the first frame update
    void Start()
    {
        triggerd = false;
        DlgCanvas.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && !triggerd)
        {
            triggerd = true;
            DlgCanvas.SetActive(true);
        }
    }
}
