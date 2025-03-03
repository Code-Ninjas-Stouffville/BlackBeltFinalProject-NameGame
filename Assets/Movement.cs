using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // Speed at which the cube moves

    void Update()
    {
        // Input handling for vertical movement
        float verticalInput = Input.GetAxis("Vertical");

        // Calculate movement direction and normalize it to avoid diagonal speed boost
        Vector3 moveDirection = new Vector3(0f, verticalInput, 0f).normalized;

        // Move the cube
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime);
    }
}