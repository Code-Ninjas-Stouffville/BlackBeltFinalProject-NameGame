using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    [Header("GameController Object for Controlling the game")]
    public GameController gameController;
    [Header("Default Velocity")]
    public float velocity = 1;
    private Rigidbody2D rb;
    private float objectHeight;

    public AudioSource audioSource; // Reference to the AudioSource

    // Start is called before the first frame update
    void Start()
    {
        gameController = GetComponent<GameController>();

        Time.timeScale = 1;
        rb = GetComponent<Rigidbody2D>();
        objectHeight = transform.GetComponent<SpriteRenderer>().bounds.size.y / 2;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            rb.velocity = Vector2.up * velocity;
            audioSource.Play();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "HighSpike" || collision.gameObject.tag == "LowSpike" || collision.gameObject.tag == "Ground" )
        {
            Time.timeScale = 0;
        }

        GameObject.Find("GameController").GetComponent<GameControllerBIrd>().GameOver();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Time.timeScale = 0;
            GameObject.Find("GameController").GetComponent<GameControllerBIrd>().GameOver();
        }
      
    }
}
