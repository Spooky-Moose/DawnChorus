using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestItemPickedUp : MonoBehaviour
{

    public GameObject gameManager;

    [HideInInspector]
    public bool itemInteracted = false;
    [HideInInspector]
    //private bool interactionCheck = true;


    public void PickedUp()
    {
        Debug.Log("Interaction Check");
        gameManager.GetComponent<GameManager>().questItemsInteracted++;
        //itemInteracted = true;
        //interactionChecker();   
    }

    private void interactionChecker()
    {
        //interactionCheck = false;
        if (itemInteracted)
        {
            gameManager.GetComponent<GameManager>().questItemsInteracted++;
            Debug.Log("item incremented");
        }
        
    }

}
