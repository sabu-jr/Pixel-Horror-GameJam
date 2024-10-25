using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene5BeginRiddle : MonoBehaviour
{
    [SerializeField] GameObject InfoCanvas;
    // Start is called before the first frame update
    private bool Beginriddle;

    private int index;
    void Start()
    {
        InfoCanvas.SetActive(false);
        Beginriddle = false;
        index = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Couchgoblin")
        {
            Beginriddle = true;
            Debug.Log("BeginRiddle");
        }
        if(Beginriddle)
        {
            if (collision.gameObject.name == "Wine")
            {
                Debug.Log("BeginRiddle if Wine");
                InfoCanvas.SetActive(true);
            }
            if (collision.gameObject.name == "Toolset")
            {
                InfoCanvas.SetActive(true);
            }
            if (collision.gameObject.name == "Hourglass")
            {
                InfoCanvas.SetActive(true);
            }

            if (collision.gameObject.name == "couchgoblin")
            {
                if(index == 1 || index == 2)
                {
                    //fail
                }
                if(index ==3)
                {
                    //pass
                }
            }
        }
        
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        InfoCanvas.SetActive(false);
    }
}
