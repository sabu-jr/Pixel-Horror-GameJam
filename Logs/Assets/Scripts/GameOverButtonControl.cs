using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverButtonControl : MonoBehaviour
{
    // Start is called before the first frame update
    public void onPressRestart()
    {
        SceneManager.LoadScene(1);
    }
    public void onPressQuit()
    {
        Application.Quit();
    }
}
