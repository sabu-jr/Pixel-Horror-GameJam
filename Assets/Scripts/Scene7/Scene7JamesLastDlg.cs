using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene7JamesLastDlg : MonoBehaviour
{

    [SerializeField] GameObject LastDlgCanvas;
    private bool Trigger;
    // Start is called before the first frame update
    void Start()
    {
        Trigger = false;
        LastDlgCanvas.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && !Trigger)
        {
            LastDlgCanvas.SetActive(true);
            Trigger = true;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            int SceneIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(SceneIndex+1);
        }
    }
}
