using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
