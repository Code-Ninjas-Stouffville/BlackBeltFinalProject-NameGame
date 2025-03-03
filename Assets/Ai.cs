using UnityEngine;

public class Ai : MonoBehaviour
{
    public Transform vsd;
    public Transform ball;       // Reference to the ball's transform
    public float speed = 5f;     // Speed of the AI paddle movement
    public float verticalLimit = 3.5f;  // Vertical movement limit for the AI paddle
    public GameObject[] ballGameObjects;

    void Update()
    {
        ballGameObjects = GameObject.FindGameObjectsWithTag("Ball");
        if (ballGameObjects!=null)
        {
            int  i = UnityEngine.Random.Range(0, ballGameObjects.Length-1);
            ball = ballGameObjects[i].transform;
        }
        if (ball != null)
        {
            // Get the current position of the AI paddle
            Vector3 currentPosition = transform.position;

            // Clamp the AI paddle's vertical position within the defined limits
            currentPosition.y = Mathf.Clamp(currentPosition.y, -verticalLimit, verticalLimit);

            // Calculate the target position based on the ball's y-position
            Vector3 targetPosition = currentPosition;
            targetPosition.y = ball.position.y;

            // Move the AI paddle towards the target position
            transform.position = Vector3.MoveTowards(currentPosition, targetPosition, speed * Time.deltaTime);
        }
    }
}