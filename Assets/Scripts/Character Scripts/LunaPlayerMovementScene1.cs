using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LunaPlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 5f;
    [SerializeField]
    private Transform GrounCheck;
    [SerializeField]
    private LayerMask groundlayer;
    [SerializeField]
    private Transform cameraFollow;
    [SerializeField]
    private GameObject UICanvas;
    [SerializeField]
    private Animator animator;


    public bool hasKey = false;
    private Rigidbody2D rb;
    private float HorizontalIP;
    
    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        HorizontalIP = Input.GetAxisRaw("Horizontal");
 
    }

    private void FixedUpdate()
    {
        if (!UICanvas.gameObject.activeSelf)
        {
            rb.velocity = new Vector2(HorizontalIP * moveSpeed, rb.velocity.y);
   
        }
        if(Input.GetAxisRaw("Horizontal") > 0)
        {
            animator.SetBool("isWalkingRight", true);
        }
        else if (Input.GetAxisRaw("Horizontal") < 0)
        {
            animator.SetBool("isWalkingLeft", true);
        }
        else
        {
            animator.SetBool("isWalkingRight", false);
            animator.SetBool("isWalkingLeft", false);
        }
    }

 

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "CameraBoundRight")
        {
            cameraFollow.position = new Vector2(cameraFollow.position.x + 13.45f, cameraFollow.position.y);
        }
        if(collision.gameObject.name == "CameraBoundLeft")
        {
            cameraFollow.position = new Vector2(cameraFollow.position.x - 13.45f, cameraFollow.position.y);
        }
        if (collision.gameObject.name == "UITrigger")
        {
            UICanvas.gameObject.SetActive(true);
        }
        if (collision.gameObject.name == "Block1Door" && hasKey)
        {
            SceneManager.LoadScene(2);
        }
        if( collision.gameObject.name == "Key" && hasKey==false)
        {
            collision.gameObject.SetActive(false);
            Destroy(collision.gameObject);
            hasKey = true;
        }
    }
}
