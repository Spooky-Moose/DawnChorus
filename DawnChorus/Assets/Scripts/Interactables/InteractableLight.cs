using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class InteractableLight : MonoBehaviour
{

    public void PickedUp()
    {
        GetComponent<Light>().intensity = 0;
    }

    public void Dropped()
    {
        GetComponent<Light>().intensity = 3;
    }

}
