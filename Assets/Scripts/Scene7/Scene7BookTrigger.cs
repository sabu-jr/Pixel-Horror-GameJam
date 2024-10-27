using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene7BookTrigger : MonoBehaviour
{
    [SerializeField] private GameObject dlgTrigger;
    // Start is called before the first frame update
    void Start()
    {
        dlgTrigger.SetActive(false);
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            dlgTrigger.SetActive(true);
        }
    }
}
