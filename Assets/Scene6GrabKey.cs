using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene6GrabKey : MonoBehaviour
{
    [SerializeField] GameObject DlgCanvas;
    [SerializeField] GameObject MonsterChaseDlg;
    [SerializeField] GameObject InfoCanvas;

    private bool HasKey;
    // Start is called before the first frame update
    void Start()
    {
        DlgCanvas.SetActive(false);
        MonsterChaseDlg.SetActive(false);
        HasKey = false;
        InfoCanvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Key")
        {
            HasKey = true;
            DlgCanvas.SetActive(true);
            Destroy(collision.gameObject);
        }
        if(collision.gameObject.name == "Clyde")
        {
            MonsterChaseDlg.SetActive(true) ;
            InfoCanvas.SetActive(true) ;
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Door" && HasKey)
        {
            if(Input.GetKeyUp(KeyCode.E))
            {
                int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
                SceneManager.LoadScene(currentSceneIndex + 1);
            }
        }
    }
}
