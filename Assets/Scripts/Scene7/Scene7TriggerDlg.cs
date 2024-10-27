using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene7TriggerDlg : MonoBehaviour
{
    [SerializeField] GameObject DlgCanvas;
    // Start is called before the first frame update
    void Start()
    {
        DlgCanvas.SetActive(false);
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "ClydeDlgTrigger")
        {
            DlgCanvas.SetActive(true);
        }
    }
}
