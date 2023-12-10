using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompanionAnimation : MonoBehaviour
{
    public float floatHeight = 1.0f; // Adjust this value to set the float height
    public float floatSpeed = 1.0f; // Adjust this value to set the float speed

    private void Update()
    {
        // Calculate the new Y position using Mathf.Sin to create a float effect
        float newY = transform.position.y + Mathf.Sin(Time.time * floatSpeed) * floatHeight * Time.deltaTime;

        // Apply the new position to the GameObject
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }
}
