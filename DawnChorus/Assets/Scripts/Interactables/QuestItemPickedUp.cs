using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestItemPickedUp : MonoBehaviour
{

    public GameManager gameManager;

    [HideInInspector]
    public bool itemInteracted = false;
    [HideInInspector]
    public int itemCount;

    public void Start()
    {
        Debug.Log(gameManager);
        Debug.Log(gameManager.questItemsInteracted);
        itemCount = 0;
    }

    public void Update()
    {
        //itemCount = gameManager.questItemsInteracted;
        gameManager.questItemsInteracted = itemCount;
    }

    public void PickedUp()
    {
        Debug.Log("Interaction Check");
        
        itemCount++;
        Debug.Log(itemCount);
        //gameManager.incrementQuestItem();
        //itemInteracted = true;
        //interactionChecker();   
    }

    private void interactionChecker()
    {
        //interactionCheck = false;
        if (itemInteracted)
        {
            gameManager.questItemsInteracted++;
            Debug.Log("item incremented");
        }
        
    }

}
