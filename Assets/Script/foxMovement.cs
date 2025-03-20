using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;


public class foxMovement : MonoBehaviour
{
    public float rotationSpeed = 90f; // Rotation speed in degrees per second
    public float spinChance = 0.1f;  // Chance for the object to start spinning (0.5 = 50%)

  
    private bool shouldSpin = false;  // Whether the object should spin or not
  
    public float minSpeed = 20f; // Minimum speed
    public float maxSpeed = 40f; // Maximum speed
    public float moveDistance = 5f; // How far the sprite moves before reversing
     private float speed; // Current speed
    private float speedChangeTimer = 0f;
    public float speedChangeInterval = 2f; // Time interval in seconds to change speed



    public AudioSource audioSource; // Reference to the AudioSource
    public Rigidbody2D rb;

    void Start()
    {
         speed = Random.Range(minSpeed, maxSpeed); // Set initial random speed
    
        audioSource = GameObject.Find("Boom").GetComponent<AudioSource>();
        Destroy(gameObject, 10f);
        audioSource.volume = 100f;

        if (Random.value <= spinChance)
        {
            shouldSpin = true;
        }

    }
    // Update is called once per frame
    void Update()
    {
        
          speedChangeTimer += Time.deltaTime;
        if (speedChangeTimer >= speedChangeInterval)
        {
            speed = Random.Range(minSpeed, maxSpeed); // Set a new random speed
            speedChangeTimer = 0f; // Reset the timer
        }
          rb.velocity = new Vector2 (-speed,0);

         if (shouldSpin)
        {
            transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
        }

    }
    void OnMouseDown()
    {

        Destroy(this.gameObject);

          audioSource.Play();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "End")
        {
            Time.timeScale = 0;
            
             GameObject.Find("GameController").GetComponent<GameControllerBIrd>().GameOver();
        }
    }
}


