using Leap;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnField : MonoBehaviour
{
    // Specify the tag that triggers the transform reset
    public string targetTag = "YourTargetTag"; 

    private void OnTriggerEnter(Collider other)
    {
        // Check if the entering GameObject has the specified tag
        if (other.CompareTag(targetTag))
        {
            // Reset the transform of the entering GameObject
            ResetTransform(other.gameObject);
        }
    }

    private void ResetTransform(GameObject objToReset)
    {
        // Reset the position, rotation of the specified GameObject
        objToReset.transform.position = new Vector3(0.129999995f, 1.01600003f, -0.228f);
        objToReset.transform.rotation = Quaternion.identity;

        // Check if the GameObject has a Rigidbody
        Rigidbody rigidbody = objToReset.GetComponent<Rigidbody>();
        if (rigidbody != null)
        {
            // Reset the velocity of the Rigidbody
            rigidbody.velocity = Vector3.zero;
        }
    }
}

//Vector3(0, 0.920000017, 0.352999985)