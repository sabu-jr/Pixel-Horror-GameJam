using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene6GrabKey : MonoBehaviour
{
    [SerializeField] GameObject DlgCanvas;
    [SerializeField] GameObject InfoCanvas;
    [SerializeField] TMP_Text text;

    private bool HasKey;
    // Start is called before the first frame update
    void Start()
    {
        DlgCanvas.SetActive(false);
        HasKey = false;
        InfoCanvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Key")
        {
            HasKey = true;
            DlgCanvas.SetActive(true);
            Destroy(collision.gameObject);
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Door" && HasKey)
        {
            text.text = "Press E to Open the door";
            InfoCanvas.SetActive(true);
            if(Input.GetKeyUp(KeyCode.E))
            {
                int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
                SceneManager.LoadScene(currentSceneIndex + 1);
            }
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Door" && HasKey)
        {
            InfoCanvas.SetActive(false);
        }
    }
}
