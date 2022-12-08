using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverActivation : MonoBehaviour
{
    public GameObject leverLight;
    private bool leverActivated = false;
    private bool triggerActivated = false;

    public GameObject door;
    public GameObject initDoorDestination;
    public GameObject finalDoorDestination;
    public float smoothTime = 0.5f;
    Vector3 currentVelocity;

    public void Start()
    {
        leverActivated = false;
        triggerActivated = false;
    }

    private void OnTriggerEnter(Collider other)
    {

        if (leverActivated)
        {
            if (other.tag == "Triggerable")
            {
                Debug.Log("Lever Activated");
                door.GetComponent<AudioSource>().Play();
                triggerActivated = true;
            }
        }


    }

    private void OnTriggerExit(Collider other)
    {
        
       /* if (leverActivated)
        {
            if (other.tag == "Triggerable")
            {
                triggerActivated = false;
                door.GetComponent<AudioSource>().Play();
            }
        }*/
    }

    public void Update()
    {
        if (leverLight.GetComponent<Light>().color == Color.green)
        {
            leverActivated = true;
        }

        if (triggerActivated)
        {
            door.transform.position = Vector3.SmoothDamp(door.transform.position, finalDoorDestination.transform.position, ref currentVelocity, smoothTime);
        }
        /*else if (!triggerActivated)
        {
            door.transform.position = Vector3.SmoothDamp(door.transform.position, initDoorDestination.transform.position, ref currentVelocity, smoothTime);
        }*/

    }

}
