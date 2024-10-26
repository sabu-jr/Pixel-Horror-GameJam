using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Xml;

public class Scene5BeginRiddle : MonoBehaviour
{
    [SerializeField] GameObject InfoCanvas;
    [SerializeField] GameObject Pass;
    [SerializeField] GameObject Fail;
    [SerializeField] GameObject DlgSystem;
    [SerializeField] TMP_Text tmpText;
    [SerializeField] GameObject attack;
    // Start is called before the first frame update
    private bool Beginriddle;

    private int index;
    void Start()
    {
        InfoCanvas.SetActive(false);
        Pass.SetActive(false);
        Fail.SetActive(false);
        attack.SetActive(false);

        Beginriddle = false;
        index = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Couchgoblin" && !Beginriddle)
        {
            Beginriddle = true;
            DlgSystem.SetActive(true);
            Debug.Log("BeginRiddle");
        }
        if(Beginriddle)
        {
            if (collision.gameObject.name == "Couchgoblin")
            {
                if (index == 1 || index == 2)
                {
                    //fail
                    attack.SetActive(true);
                    Fail.SetActive(true);
                }
                if (index == 3)
                {
                    //pass
                    collision.gameObject.GetComponent<BoxCollider2D>().enabled = false;
                    Pass.SetActive(true);
                }
            }
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Beginriddle)
        {
            if (collision.gameObject.name == "Wine")
            {
                Destroy(DlgSystem);
                InfoCanvas.SetActive(true);
                if (Input.GetKeyDown(KeyCode.E))
                {
                    tmpText.text = "Wine picked";
                    index = 1;
                    InfoCanvas.SetActive(false);
                }

            }
            if (collision.gameObject.name == "Toolset")
            {
                Destroy(DlgSystem);
                InfoCanvas.SetActive(true);
                if (Input.GetKeyDown(KeyCode.E))
                {
                    tmpText.text = "Book picked";
                    index = 2;
                    InfoCanvas.SetActive(false);
                }
            }
            if (collision.gameObject.name == "Hourglass")
            {
                Destroy(DlgSystem);
                InfoCanvas.SetActive(true);
                if (Input.GetKeyDown(KeyCode.E))
                {
                    tmpText.text = "Hourglass picked";
                    index = 3;
                    InfoCanvas.SetActive(false);
                }
            }
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        InfoCanvas.SetActive(false);
    }
}
