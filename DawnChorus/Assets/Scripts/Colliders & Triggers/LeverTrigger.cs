using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using UnityEngine;

public class LeverTrigger : MonoBehaviour
{

    public GameObject movingObject;
    public GameObject initLocation;
    public GameObject moveLocation;

    public GameObject leverAudio;
    
    public bool triggerActivated = false;
    

    public float speed = 3;
    public float smoothTime = 0.5f;
    public Vector3 target = new Vector3(-4, 0, 10);
    //public Vector3 initTarget;
    Vector3 currentVelocity;


    private void Awake()
    {
        gameObject.GetComponent<LeverTrigger>().enabled = false;
        gameObject.GetComponent<BoxCollider>().enabled = false;
    }
    private void Start()
    {
        leverAudio.GetComponent<AudioSource>().Play();
    }

    private void OnTriggerEnter(Collider other)
    {

        if (!triggerActivated)
        {
            if (other.tag == "Triggerable")
            {
                Debug.Log("Lever Activated");
                movingObject.GetComponent<AudioSource>().Play();
                triggerActivated = true;
            }
        }
        
        
    }

    private void OnTriggerExit(Collider other)
    {
        triggerActivated = false;
    }

    public void Update()
    {
        if (triggerActivated)
        {
            movingObject.transform.position = Vector3.SmoothDamp(movingObject.transform.position, moveLocation.transform.position, ref currentVelocity, smoothTime);
        }
        /*else if (!triggerActivated)
        {
            movingObject.transform.position = Vector3.SmoothDamp(movingObject.transform.position, initLocation.transform.position, ref currentVelocity, smoothTime);
        }*/
        
    }


}
