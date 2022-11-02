using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FriendCollider : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        AudioSource friendNoise = GetComponent<AudioSource>();

        if (other.tag == "Player")
        {
            friendNoise.Play();
        }

    }
}
