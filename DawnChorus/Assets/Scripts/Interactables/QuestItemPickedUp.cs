using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestItemPickedUp : MonoBehaviour
{

    public GameManager gameManager;

    [HideInInspector]
    public bool itemInteracted = false;
    [HideInInspector]
    private bool interactionCheck = true;


    public void PickedUp()
    {
        if (interactionCheck)
        {
            itemInteracted = true;
            interactionChecker();
        }
        
    }

    private void interactionChecker()
    {
        interactionCheck = false;
        gameManager.questItemsInteracted++;
    }

}
