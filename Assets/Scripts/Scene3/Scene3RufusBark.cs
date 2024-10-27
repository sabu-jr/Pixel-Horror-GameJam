using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene3RufusBark : MonoBehaviour
{
    [SerializeField] AudioSource AudioSource;
    [SerializeField] Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        AudioSource.Pause();
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Monster"))
        {
            AudioSource.Play();
            animator.SetBool("Barking",true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Monster"))
        {
            animator.SetBool("Barking", false);
        }
    }
}
