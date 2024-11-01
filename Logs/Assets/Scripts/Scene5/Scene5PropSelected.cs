using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene5PropSelected : MonoBehaviour
{
    [SerializeField] GameObject wine;
    [SerializeField] GameObject toolkit;
    [SerializeField] GameObject hourglass;


    [SerializeField] GameObject InfoCanvas;
    [SerializeField] GameObject PassCanvas;
    [SerializeField] GameObject FailCanvas;
    [SerializeField] GameObject DialogueCanvas;

    [SerializeField] GameObject CouchGoblin;
    //[SerializeField] Animator animator;

    private int index;
    private bool BeginRiddle;
    private BoxCollider2D BCollider;
    // Start is called before the first frame update
    void Start()
    {
        InfoCanvas.SetActive(false);
        PassCanvas.SetActive(false);
        FailCanvas.SetActive(false);
        DialogueCanvas.SetActive(false);

        BeginRiddle = false;
        index = 0;

        BCollider= CouchGoblin.GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Couchgoblin")
        {
            BeginRiddle=true;
            Debug.Log("Begin Riddle");
        }
        if (collision.gameObject.name == "Wine" && BeginRiddle)
        {
            //index = 1;
            InfoCanvas.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("Wine Picked");
                index = 1;
            }
        }
        if (collision.gameObject.name == "Toolkit " && BeginRiddle)
        {
            //index = 2;
            InfoCanvas.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("Toolkit Picked");
                index = 1;
            }
        }
        if (collision.gameObject.name == "Hourglass" && BeginRiddle)
        {
            //index = 3;
            InfoCanvas.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("Hourglass Picked");
                index = 1;
            }
        }
        if(collision.gameObject.name == "Couchgoblin" &&  BeginRiddle)
        {
            if(index == 1 || index == 2)
            {
                DialogueCanvas.SetActive(false);
                FailCanvas.SetActive(true);
            }
            if(index == 3)
            {
                //pass
                //defeat animation
                DialogueCanvas.SetActive(false);
                PassCanvas.SetActive(true);
                BCollider.enabled = false;
            }
        }
    }
}
