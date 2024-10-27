using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene5CouchGoblinAnimations : MonoBehaviour
{
    private Animator animator;
    private BoxCollider2D col;
    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        animator=GetComponent<Animator>();
        col=GetComponent<BoxCollider2D>();
        audioSource=GetComponent<AudioSource>();
    }

    // Update is called once per frame
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && col.enabled == true)
        {
            animator.SetBool("Rawring", true);

        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            animator.SetBool("Rawring", false);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            audioSource.Play();
        }
    }
}
