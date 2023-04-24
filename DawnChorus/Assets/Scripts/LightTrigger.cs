using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightTrigger : MonoBehaviour
{

    public GameObject leverLight;
    public GameObject roomLight1;
    public GameObject roomLight2;

    private bool lightsActivated = false;

    private Color initColor;
    private Color greenColor = new Color(40, 253, 11);

    public void Start()
    {
        roomLight1.GetComponent<Light>().intensity = 0;
        roomLight2.GetComponent<Light>().intensity = 0;
        initColor = leverLight.GetComponent<Light>().color;
        lightsActivated = false;

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Triggerable")
        {
            leverLight.GetComponent<Light>().color = Color.green;
            lightsActivated = true;
            PlayAnims();
        }
          
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Triggerable")
        {
            leverLight.GetComponent<Light>().color = initColor;
            lightsActivated = false;
            PlayAnims();
        }

        
    }

    private void PlayAnims()
    {
        if (lightsActivated)
        {
            roomLight1.GetComponent<Animation>().Play("OnAnim");
            roomLight2.GetComponent<Animation>().Play("OnAnim");
        }
        /*else
        {
            roomLight1.GetComponent<Animation>().Play("OffAnim");
            roomLight2.GetComponent<Animation>().Play("OffAnim");

        }*/
    }


}
