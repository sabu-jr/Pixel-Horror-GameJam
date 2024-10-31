using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnPausePress : MonoBehaviour
{
    [SerializeField] GameObject Pausecanvas;
    [SerializeField] GameObject[] Actors;
    void Start()
    {
        Pausecanvas.SetActive(false);
    }

    private void FixedUpdate()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            PressPause();
        }
    }

    public void PressPause()
    {
        foreach (GameObject Actor in Actors)
        {
            Actor.SetActive(false);
        }
        Pausecanvas.SetActive(true);
    }
    public void ResumeButton()
    {
        foreach (GameObject Actor in Actors)
        {
            Actor.SetActive(true);
        }
        Pausecanvas.SetActive(false);
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
