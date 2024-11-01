using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene6FailProgression : MonoBehaviour
{
    [SerializeField] AudioSource ChaseAudio;

    private void Start()
    {
        ChaseAudio.Play();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
