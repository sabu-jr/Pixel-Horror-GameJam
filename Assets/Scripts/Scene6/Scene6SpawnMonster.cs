using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene6SpawnMonster : MonoBehaviour
{
    [SerializeField] GameObject monster;
    [SerializeField] Animator animator;
    [SerializeField] GameObject MonsterSpawn;
    [SerializeField] Transform CameraFollow;
    [SerializeField] GameObject MonsterSpawnDlg;
    [SerializeField] GameObject CameraBound;
    [SerializeField] Collider2D ClydeCollider;
    [SerializeField] AudioSource MonsterAudio;

    private Animator SpawnAnimator;
    private bool Triggered;
    //[SerializeField] AudioSource ChaseAudio;
    // Start is called before the first frame update
    void Start()
    {
        Triggered = false;
        ClydeCollider.enabled = true;
        SpawnAnimator = MonsterSpawn.GetComponent<Animator>();
        SpawnAnimator.enabled = false;
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
            CameraBound.SetActive(false);
            CameraFollow.position = new Vector3(40.8f, 0, -10f);
            SpawnAnimator.enabled = true;
            MonsterAudio.Play();
            StartCoroutine(WaitForAnimation());
            animator.SetBool("Run",true);
        }
    }
    private IEnumerator WaitForAnimation()
    {
        // Wait until the current animation has finished playing
        while (SpawnAnimator.GetCurrentAnimatorStateInfo(0).normalizedTime < 1)
        {
            yield return null; // Wait until the next frame
        }

        // Animation has finished; execute the next line of code
        if (!Triggered)
        {
            MonsterSpawnDlg.SetActive(true);
            Triggered = true;
        }
        CameraBound.SetActive(true);
        CameraFollow.position = new Vector3(54.4f, 0, -10f);
        ClydeCollider.enabled = false;
    }
}
