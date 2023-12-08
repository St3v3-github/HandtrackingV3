using Leap;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnField : MonoBehaviour
{
    public Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    void OnTriggerEnter()
    {
        if (gameObject.tag == "Interactable")
        {
            transform.position = startPos;
        }
    }
}
