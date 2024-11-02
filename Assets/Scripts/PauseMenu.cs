using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    [SerializeField] GameObject[] Actors;
    // Start is called before the first frame update
    void Start()
    {
        foreach (GameObject Actor in Actors)
        {
            Actor.SetActive(false);
        }
    }

    public void ResumeButton()
    {
        foreach (GameObject Actor in Actors)
        {
            Actor.SetActive(true);
        }
        gameObject.SetActive(false);
    }
    public void BackButton()
    {
        SceneManager.LoadScene(0);
    }
    public void QuitButton()
    {
        Application.Quit();
    }
}
