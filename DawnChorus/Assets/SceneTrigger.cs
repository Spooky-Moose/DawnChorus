using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneTrigger : MonoBehaviour
{

    public SceneTransitionManager sceneTransition;
    public int sceneIndex = 0;

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            sceneTransition.GoToScene(sceneIndex);
        }
            
    }
}
