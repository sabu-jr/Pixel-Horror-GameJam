using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.InputSystem.Controls.AxisControl;

public class Scene4LampFae : MonoBehaviour
{
    [SerializeField] private GameObject Roomkey;
    [SerializeField] private GameObject LampFae;
    [SerializeField] private GameObject Fae;
    [SerializeField] private GameObject Lamp;
    [SerializeField] private AudioSource audioSource;

    private Rigidbody2D rbKey;
    private Rigidbody2D rbLamp;
    private SpriteRenderer KeySprite;
    private void Start()
    {
        rbKey = Roomkey.GetComponent<Rigidbody2D>();
        rbLamp = Lamp.GetComponent<Rigidbody2D>();
        KeySprite = Roomkey.GetComponent<SpriteRenderer>();
        KeySprite.enabled = false;
        audioSource.GetComponent<AudioSource>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            audioSource.Play();
            rbKey.gravityScale = 1.0f;
            KeySprite.enabled = true;

            LampFae.SetActive(false);
            Lamp.SetActive(true);
            Fae.SetActive(true);
            rbLamp.gravityScale = 0.5f;
        }

    }
}
