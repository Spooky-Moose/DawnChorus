using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class QuestItemPickedUp : MonoBehaviour
{
    public bool pickedUp = false;
    private string tagName = "ProgressionItem";


    public void Start()
    {
        pickedUp = false;
       // Debug.Log(this.gameObject.tag);
    }

    public void PickedUp()
    {        
        pickedUp = true;
        //gameObject.layer = 0;
        gameObject.tag = tagName;

        //Debug.Log(pickedUp);
        //Debug.Log(this.gameObject.tag);
    }


    public void Update()
    {
        if (pickedUp)
        {
            gameObject.tag = tagName;
        }
    }



}
