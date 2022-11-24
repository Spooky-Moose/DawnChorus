using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class QuestItemPickedUp : MonoBehaviour
{
    public bool pickedUp = false;


    public void Start()
    {
        Debug.Log(this.gameObject.tag);
    }

    public void PickedUp()
    {        
        pickedUp = true;
        

        Debug.Log(pickedUp);
        Debug.Log(this.gameObject.tag);
    }

    public void tagChange()
    {
        if (pickedUp)
        {
            this.gameObject.tag = "ProgressionItem";
        }
    }



}
