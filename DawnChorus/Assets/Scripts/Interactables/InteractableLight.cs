using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class InteractableLight : MonoBehaviour
{
    //public GameObject lightSource;

    public void PickedUp()
    {
        //lightSource.GetComponent<Light>().intensity = 0;
        GetComponentInChildren<Light>().intensity = 0;

    }

    public void Dropped()
    {
        //lightSource.GetComponent<Light>().intensity = 3;
        GetComponentInChildren<Light>().intensity = 3;
    }

}
