using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class DoorActivation : MonoBehaviour
{

    public GameObject door;
    public GameObject initDoorDestination;
    public GameObject finalDoorDestination;
    public float smoothTime = 0.5f;
    Vector3 currentVelocity;

    private bool doorOpen = false;


    public void SocketEntered()
    {
        doorOpen = false;
        door.GetComponent<AudioSource>().Play();
        //door.transform.position = Vector3.SmoothDamp(initDoorDestination.transform.position, finalDoorDestination.transform.position, ref currentVelocity, smoothTime);
    }

    public void SocketExit()
    {
        doorOpen = true;
        door.GetComponent<AudioSource>().Play();
        //door.transform.position = Vector3.SmoothDamp(finalDoorDestination.transform.position, initDoorDestination.transform.position, ref currentVelocity, smoothTime);
    }

    public void Update()
    {
        if (doorOpen)
        {
            door.transform.position = Vector3.SmoothDamp(door.transform.position, finalDoorDestination.transform.position, ref currentVelocity, smoothTime);
            door.GetComponent<AudioSource>().Play();
        }
        else if (!doorOpen)
        {
            door.transform.position = Vector3.SmoothDamp(door.transform.position, initDoorDestination.transform.position, ref currentVelocity, smoothTime);
            door.GetComponent<AudioSource>().Play();
        }
    }
}
