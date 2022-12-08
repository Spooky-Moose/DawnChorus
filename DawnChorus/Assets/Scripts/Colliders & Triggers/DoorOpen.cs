using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{

    public GameObject door;
    public GameObject initDoorDestination;
    public GameObject finalDoorDestination;
    public float smoothTime = 0.5f;
    Vector3 currentVelocity;

    private bool doorOpen = false;


    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            doorOpen = true;
            door.GetComponent<AudioSource>().Play();
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            doorOpen = false;
            door.GetComponent<AudioSource>().Play();
        }
    }

    public void Update()
    {
        if (doorOpen)
        {
            door.transform.position = Vector3.SmoothDamp(door.transform.position, finalDoorDestination.transform.position, ref currentVelocity, smoothTime);
            
        }
        else if (!doorOpen)
        {
            door.transform.position = Vector3.SmoothDamp(door.transform.position, initDoorDestination.transform.position, ref currentVelocity, smoothTime);
            
        }
    }
}
