using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LightTrigger2 : MonoBehaviour
{
    public GameObject leverLight;
    public GameObject oppositeTriggerBox;

    public GameObject door;
    public GameObject initDoorDestination;
    public GameObject finalDoorDestination;
    public float smoothTime = 0.5f;
    Vector3 currentVelocity;


    private bool leverActivated = false;

    private Color initColor;
    private Color greenColor = new Color(40, 253, 11);

    public void Start()
    {
        //roomLight1.GetComponent<Light>().intensity = 0;
        //roomLight2.GetComponent<Light>().intensity = 0;
        initColor = leverLight.GetComponent<Light>().color;
        leverActivated = false;

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Triggerable")
        {
            leverLight.GetComponent<Light>().color = Color.green;
            leverActivated = true;

            if (this.tag == "ProgressionItem")
            {
                door.GetComponent<AudioSource>().Play();
            }
            //PlayAnims();
        }

    }

    public void Update()
    {
        if (leverActivated)
        {
            oppositeTriggerBox.GetComponent<LightTrigger2>().enabled = false;

            if (this.tag == "ProgressionItem")
            {
                door.transform.position = Vector3.SmoothDamp(door.transform.position, finalDoorDestination.transform.position, ref currentVelocity, smoothTime);
            }
        }


    }


}
