using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccelerometerRotation : MonoBehaviour
{
    // Adjust this value to control the rotation speed
    public float rotationSpeed = 5.0f;

    // Threshold for acceleration change to log
    private float accelerationThreshold = 0.1f;

    // Update is called once per frame
    void Update()
    {
        // Check if accelerometer is available
        if (SystemInfo.supportsAccelerometer)
        {
            // Get the accelerometer input
            Vector3 acceleration = Input.acceleration;

            // Apply the rotation to the attached game object based on acceleration
            transform.Rotate(new Vector3(-acceleration.y, acceleration.x, 0) * rotationSpeed * Time.deltaTime);

            // Check if there is a significant change in acceleration
            if (acceleration.magnitude > accelerationThreshold)
            {
                // Print acceleration values
                Debug.Log("Acceleration: " + acceleration);
            }
        }
        else
        {
            Debug.LogError("Accelerometer not supported on this device.");
        }
    }
}
