using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using UnityEngine;


public class AIPaddle : MonoBehaviour
{

    public Rigidbody2D rb;
    public Transform ball;
    private float movement = 1;
    public float speed = 5f;     // Speed of the AI paddle movement
    public float verticalLimit = 3.5f;  // Vertical movement limit for the AI paddle
    public Vector3 startPosition;

    private float aiDelay;
    public float delayTimer;

    private Vector3 targetPosition;
    private Vector3 currentPosition;

    public float minReflexTime;
    public float maxReflexTime;
    void Start()
    {
        startPosition = transform.position;
        aiDelay = UnityEngine.Random.Range(minReflexTime, maxReflexTime);
        delayTimer = 0;
        currentPosition = transform.position;
    }

    void Update()
    {
        delayTimer = delayTimer + Time.deltaTime;
        if (delayTimer > aiDelay)
        {
            currentPosition = transform.position;
            // Calculate the target position based on the ball's y-position
            targetPosition = currentPosition;
            targetPosition.y = ball.position.y;
            delayTimer = 0;
            aiDelay = aiDelay = UnityEngine.Random.Range(minReflexTime, maxReflexTime);

        }


        if (ball != null)
        {

            // Get the current position of the AI paddle

            if (currentPosition.y <= targetPosition.y)
            {
                movement = 1;
            }
            else if (currentPosition.y > targetPosition.y)
            {
                movement = -1;
            }


            rb.velocity = new Vector2(rb.velocity.x, movement * speed);
            // Move the AI paddle towards the target position
            //transform.position = Vector3.MoveTowards(currentPosition, targetPosition, speed * Time.deltaTime);
        }
    }
    public void Reset()
    {
        rb.velocity = Vector2.zero;
        transform.position = startPosition;
    }
}
