using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene7BookTrigger : MonoBehaviour
{
    [SerializeField] private GameObject dlgTrigger;
    private bool Trigger;
    // Start is called before the first frame update
    void Start()
    {
        Trigger = false;
        dlgTrigger.SetActive(false);
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && !Trigger)
        {
            Trigger = true;
            dlgTrigger.SetActive(true);
        }
    }
}
