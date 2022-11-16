using UnityEngine;
using UnityEngine.Rendering;
//using UnityEngine.Rendering.PostProcessing;
using UnityEngine.SceneManagement;

public class Target : MonoBehaviour
{
    public float health = 10f;
    //public PostProcessProfile doubleP;
    
    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0f)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
        if (gameObject.tag == "Friend")
        {
            Debug.Log("You killed a child");
            //vignette.intensity.value = 0.5f;
            
        }
        else if (gameObject.tag == "Foe")
        {
            Debug.Log("Congrats you save the world");
            

        }
    }
}
