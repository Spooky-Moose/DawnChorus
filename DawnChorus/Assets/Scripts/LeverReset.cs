using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverReset : MonoBehaviour
{

    public GameObject movingObject;
    //public GameObject initLocation;
    //public GameObject moveLocation;

    public float speed = 3;
    public float smoothTime = 0.5f;
    //public Vector3 target = new Vector3(0, 0, 50);
    public Quaternion target = new Quaternion();

    //public Vector3 initTarget;
    Vector3 currentVelocity;
    public GameScript trigger;

    public bool deactivated;

    public void Start()
    {
        deactivated = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!trigger.allItemsInteracted)
        {
            if (other.tag == "Triggerable")
            {
                deactivated = true;
                Debug.Log("Lever Activated");
                
            }
        }
    }

    private void Update()
    {

        if (deactivated)
        {
            movingObject.transform.localRotation = Quaternion.Slerp(movingObject.transform.localRotation, target, speed);
            Invoke("deactivateLeverMovement", 1.0f);
        }
    }

    public void deactivateLeverMovement()
    {
        deactivated = false;
        //Debug.Log("Lever Move Deactivated");
    }

}
