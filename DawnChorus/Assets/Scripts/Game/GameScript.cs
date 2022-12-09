using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
//using UnityEngine.Rendering.PostProcessing;

public class GameScript : MonoBehaviour
{
    //public PostProcessProfile doubleP;
    [HideInInspector]
    public int questItemsInteracted = 0;
    [HideInInspector]
    public bool allItemsInteracted = false;

    public GameObject leverTrigger;
    //public GameObject leverAudio;
    //public bool itemInteracted = false;

    private void Start()
    {
        //leverTrigger.GetComponent<LeverTrigger>().enabled = false;
        //questItemsInteracted = 0;
    }

    void Update()
    {
        if (GameObject.FindGameObjectsWithTag("ProgressionItem").Length == 3)
        {
            allItemsInteracted = true;
            leverTrigger.GetComponent<LeverTrigger>().enabled = true;
            leverTrigger.GetComponent<BoxCollider>().enabled = true;
            //leverAudio.GetComponent<AudioSource>().Play();
        }

    }


    public void incrementQuestItem()
    {
        questItemsInteracted++;
    }

}
