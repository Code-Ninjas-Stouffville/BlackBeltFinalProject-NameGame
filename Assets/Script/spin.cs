using UnityEngine;

public class SimpleSpin2D : MonoBehaviour
{
    public float rotationSpeed = 90f; // Rotation speed in degrees per second

    void Update()
    {
        // Rotate the object around the Z-axis (for 2D)
        transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
    }
}

