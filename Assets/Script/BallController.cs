using UnityEngine;

public class BallController : MonoBehaviour
{
    public float speed; // Adjust speed as needed

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        // Initial movement example
        Vector3 initialDirection = new Vector3(1f, 0f, 0f); // Adjust direction as needed
        rb.velocity = initialDirection.normalized * speed;
    }

    void OnCollisionEnter(Collision collision)
    {
        // Check if the ball collides with a paddle
        if (collision.gameObject.CompareTag("Paddle"))
        {
            // Reflect the ball's velocity off the paddle
            Vector3 reflection = Vector3.Reflect(rb.velocity, collision.contacts[0].normal);
            rb.velocity = reflection.normalized * speed;
        }
    }
}