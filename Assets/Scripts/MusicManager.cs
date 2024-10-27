using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicManager : MonoBehaviour
{
    private static MusicManager instance;
    private AudioSource audioSource;

    private void Awake()
    {
        // Check if an instance of MusicManager already exists
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            audioSource = GetComponent<AudioSource>();
            SceneManager.sceneLoaded += OnSceneLoaded;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        // Check if the current scene is the last scene
        if (scene.buildIndex == SceneManager.sceneCountInBuildSettings - 1 || scene.buildIndex == 6)
        {
            audioSource.Stop();
            SceneManager.sceneLoaded -= OnSceneLoaded; // Unsubscribe after stopping music in the last scene
        }
    }

    private void OnDestroy()
    {
        // Clean up event subscription when the object is destroyed
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }
}
