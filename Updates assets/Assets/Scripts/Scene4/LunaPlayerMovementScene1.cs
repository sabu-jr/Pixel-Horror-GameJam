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
    [SerializeField]
    private GameObject DoorOpenCanvas;


    public bool hasKey;
    private Rigidbody2D rb;
    private float HorizontalIP; 
    
    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        cameraFollow.position = new Vector3(0, 0, -10);
        hasKey = false;
        DoorOpenCanvas.SetActive(false);
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
            cameraFollow.position = new Vector3(10.41f, 0, -10);
        }
        if(collision.gameObject.name == "CameraBoundLeft")
        {
            cameraFollow.position = new Vector3(0, 0 ,-10);
        }
        if (collision.gameObject.name == "UITrigger")
        {
            UICanvas.gameObject.SetActive(true);
        }
        if (collision.gameObject.name == "Block1Door" && hasKey)
        {
            
            if (Input.GetKeyDown(KeyCode.E))
            {
             Debug.Log("E pressed");
            //int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
            //SceneManager.LoadScene(currentSceneIndex + 1);
            }
            DoorOpenCanvas.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Block1Door" && hasKey)
        {
            DoorOpenCanvas.SetActive(false);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "RoomKey" && hasKey == false)
        {
            collision.gameObject.SetActive(false);
            Destroy(collision.gameObject);
            hasKey = true;
        }
    }
}
