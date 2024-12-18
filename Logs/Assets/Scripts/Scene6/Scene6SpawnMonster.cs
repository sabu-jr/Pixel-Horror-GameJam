using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene6SpawnMonster : MonoBehaviour
{
    [SerializeField] GameObject monster;
    [SerializeField] Animator animator;
    //[SerializeField] AudioSource ChaseAudio;
    // Start is called before the first frame update
    void Start()
    {
        monster.SetActive(false);
        animator.SetBool("Run", false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            monster.SetActive(true);
            //ChaseAudio.Play();
            animator.SetBool("Run",true);
        }
    }
}
