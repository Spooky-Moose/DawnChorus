using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoeCollider : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        AudioSource foeNoise = GetComponent<AudioSource>();

        if (other.tag == "Player")
        {
            foeNoise.Play();
        }

    }
}
