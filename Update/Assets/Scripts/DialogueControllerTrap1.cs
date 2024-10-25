using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueControllerTrap1 : MonoBehaviour
{
    [SerializeField]
    private GameObject[] names;
    [SerializeField]
    private GameObject[] dialogues;
    [SerializeField]
    private GameObject[] portraits;
    [SerializeField]
    private GameObject trigger;

    private int index;
    // Start is called before the first frame update
    void Start()
    {
        
        index = 0;
        names[0].SetActive(true);
        dialogues[0].SetActive(true);
        portraits[0].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (index + 1 >= names.Length)
            {
                trigger.GetComponent<BoxCollider2D>().enabled = false;
                this.gameObject.SetActive(false);
            }
            else if (names[index+1] != null)
            {
                names[index].SetActive(false);
                dialogues[index].SetActive(false);
                portraits[index].SetActive(false);
                
                index+=1;

                names[index].SetActive(true);
                dialogues[index].SetActive(true);
                portraits[index].SetActive(true);
            }
            
        }
        
    }
}
