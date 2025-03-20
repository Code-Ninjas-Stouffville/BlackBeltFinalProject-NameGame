using UnityEngine;

public class RotateText : MonoBehaviour
{
    public float rotationSpeed = 30f; // Speed of rotation (degrees per second)
    public float rotationAmount = 15f; // Amount of rotation for each direction
    private bool rotatingRight = true; // Whether the text is rotating right or left
    private float currentRotation = 0f; // Track the current rotation angle

    void Update()
    {
        // Rotate the text
        if (rotatingRight)
        {
            currentRotation += rotationSpeed * Time.deltaTime; // Increase rotation angle

            // Check if the text has rotated to the right limit
            if (currentRotation >= rotationAmount)
            {
                rotatingRight = false; // Reverse the direction
                currentRotation = rotationAmount; // Fix the rotation at the right limit
            }
        }
        else
        {
            currentRotation -= rotationSpeed * Time.deltaTime; // Decrease rotation angle

            // Check if the text has rotated back to the left limit
            if (currentRotation <= -rotationAmount)
            {
                rotatingRight = true; // Reverse the direction
                currentRotation = -rotationAmount; // Fix the rotation at the left limit
            }
        }

        // Apply the rotation to the text
        transform.rotation = Quaternion.Euler(0f, 0f, currentRotation);
    }
}
