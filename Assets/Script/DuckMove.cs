using UnityEngine;

public class MoveSprite : MonoBehaviour
{
    public float minSpeed = 1f; // Minimum speed
    public float maxSpeed = 5f; // Maximum speed
    public float moveDistance = 5f; // How far the sprite moves before reversing
    public float speedChangeInterval = 2f; // Time interval in seconds to change speed

    private Vector3 startPosition;
    private bool movingRight = true;
    private float speed; // Current speed
    private float speedChangeTimer = 0f;

    void Start()
    {
        startPosition = transform.position; // Store the starting position of the sprite
        speed = Random.Range(minSpeed, maxSpeed); // Set initial random speed
    }

    void Update()
    {
        // Timer to change the speed at random intervals
        speedChangeTimer += Time.deltaTime;
        if (speedChangeTimer >= speedChangeInterval)
        {
            speed = Random.Range(minSpeed, maxSpeed); // Set a new random speed
            speedChangeTimer = 0f; // Reset the timer
        }

        // Move the sprite back and forth
        if (movingRight)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime); // Move right
            if (transform.position.x >= startPosition.x + moveDistance) // If it reaches the end
            {
                movingRight = false; // Reverse the direction
                FlipSprite(); // Flip the sprite horizontally
            }
        }
        else
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime); // Move left
            if (transform.position.x <= startPosition.x ) // If it reaches the start
            {
                movingRight = true; // Reverse the direction
                FlipSprite(); // Flip the sprite horizontally
            }
        }
    }

    // Function to flip the sprite horizontally
    void FlipSprite()
    {
        Vector3 theScale = transform.localScale;
        theScale.x = -theScale.x; // Flip the sprite by changing the sign of the X scale
        transform.localScale = theScale;
    }
}
