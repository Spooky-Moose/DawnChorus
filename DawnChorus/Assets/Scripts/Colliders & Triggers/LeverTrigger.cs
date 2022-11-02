using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using UnityEngine;

public class LeverTrigger : MonoBehaviour
{

    public GameObject movingObject;
    private bool triggerActivated = false;

    public float speed = 3;
    public float smoothTime = 0.5f;
    public Vector3 target = new Vector3(-4, 0, 10);
    Vector3 currentVelocity;

    private void OnTriggerEnter(Collider other)
    {

        if (!triggerActivated)
        {
            if (other.tag == "Lever")
            {
                Debug.Log("Loihefiohersiotghoresder");
                triggerActivated = true;
            }
        }
        
    }

    public void Update()
    {
        if (triggerActivated)
        {
            movingObject.transform.position = Vector3.SmoothDamp(movingObject.transform.position, target, ref currentVelocity, smoothTime);
        }
        
    }


}
