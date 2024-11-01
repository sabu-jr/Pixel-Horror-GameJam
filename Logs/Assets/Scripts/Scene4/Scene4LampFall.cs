using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene4LampFall : MonoBehaviour
{
    [SerializeField] Animator animator;

    private BoxCollider2D col;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        col = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("GameOver");
        }
        if (collision.gameObject.name == "Floor")
        {
            gameObject.SetActive(false);
            col.enabled = false;
        }
    }
}
