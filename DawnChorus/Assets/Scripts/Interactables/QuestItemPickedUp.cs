using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class QuestItemPickedUp : MonoBehaviour
{
    public bool pickedUp = false;  

    public void PickedUp()
    {        
        pickedUp = true;
        this.gameObject.tag = "ProgressionItem";

        Debug.Log(pickedUp);
        Debug.Log(this.gameObject.tag);
    }



}
