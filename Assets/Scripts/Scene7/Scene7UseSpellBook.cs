using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene7UseSpellBook : MonoBehaviour
{
    [SerializeField] GameObject infoCanvas;
    [SerializeField] GameObject JamesDlgCanvas;
    [SerializeField] GameObject Clyde;
    [SerializeField] GameObject James;
    [SerializeField] GameObject Florence;

    // Start is called before the first frame update
    void Start()
    {
        infoCanvas.SetActive(false);
        JamesDlgCanvas.SetActive(false);
    }

    // Update is called once per frame
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            infoCanvas.SetActive(false);
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            infoCanvas.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("Book used");
                JamesDlgCanvas.SetActive(true);
                James.SetActive(true);
                Clyde.SetActive(false);
                Florence.SetActive(false);
            }
        }
    }
}
