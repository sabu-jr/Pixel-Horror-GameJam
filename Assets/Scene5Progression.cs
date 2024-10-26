using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene5Progression : MonoBehaviour
{
    [SerializeField] GameObject DisplayCanvas;
    [SerializeField] TMP_Text tmpText;


    // Start is called before the first frame update
    private void Start()
    {
        DisplayCanvas.SetActive(false);
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            tmpText.text = "Press E to open the door";
            DisplayCanvas.SetActive(true);
            if(Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("E pressed");
                int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
                SceneManager.LoadScene(currentSceneIndex + 1);
            }
        }
    }
}
