using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//using UnityEngine.Rendering.PostProcessing;

public class GameManager : MonoBehaviour
{
    //public PostProcessProfile doubleP;
    [HideInInspector]
    public int questItemsInteracted = 0;
    public bool allItemsInteracted = false;
    //public bool itemInteracted = false;

    private void Start()
    {
        //doubleP.GetSetting<Vignette>().intensity.value = 0;
    }

    void Update()
    {
        if (GameObject.FindGameObjectsWithTag("Foe").Length <= 0)
        {
            Cursor.lockState = CursorLockMode.None;

            SceneManager.LoadScene("GoodEnd");
        }
        else if (GameObject.FindGameObjectsWithTag("Friend").Length <= 0)
        {
            Cursor.lockState = CursorLockMode.None;

            SceneManager.LoadScene("BadEnd");
        }
    }

}
