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


    public void SocketEntered()
    {
        door.transform.position = Vector3.SmoothDamp(initDoorDestination.transform.position, finalDoorDestination.transform.position, ref currentVelocity, smoothTime);
    }

    public void SocketExit()
    {
        door.transform.position = Vector3.SmoothDamp(finalDoorDestination.transform.position, initDoorDestination.transform.position, ref currentVelocity, smoothTime);
    }
}
