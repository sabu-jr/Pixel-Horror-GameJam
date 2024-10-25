using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene1StoryController : MonoBehaviour
{
    [SerializeField]private GameObject[] StoryArray;
    [SerializeField] private GameObject[] Dlgarray;

    // Start is called before the first frame update
    private int index = 0;
    private int stepcount=1;
    void Start()
    {
        StoryArray[0].gameObject.SetActive(true);
        Dlgarray[0].gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            currentDisplay();
        }
    }

    void currentDisplay()
    {
        if (index >= StoryArray.Length)
        {
            int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(currentSceneIndex + 1);
        }
        else if(stepcount%2==0)
        {
            StoryArray[index].gameObject.SetActive(true);
            Dlgarray[index].gameObject.SetActive(false);
        }
        else
        {
            Dlgarray[index].gameObject.SetActive(true);
            index++;
        }
        stepcount++;
    }
}
