using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.XR.Interaction.Toolkit;

public class VRGun : MonoBehaviour
{
    //[SerializeField] XRGrabInteractable grabInteractable;
    [SerializeField] Transform raycastOrigin;
    [SerializeField] LayerMask targetLayer;
    [SerializeField] AudioSource gunSound;

    //private void OnEnable() => grabInteractable.activated.AddListener(TriggerPulled);
    //private void OnDisable() => grabInteractable.activated.RemoveListener(TriggerPulled);

    public float damage = 5f;
    public float range = 100f;
    public float impactForce = 30f;

    public string targetName;


   /* private void TriggerPulled(ActivateEventArgs arg0)
    {
        arg0.interactor.GetComponent<XRBaseController>().SendHapticImpulse(.5f, .25f);

        FireRaycastIntoScene();
    }*/

    private void FireRaycastIntoScene()
    {
        RaycastHit hit;

        gunSound.Play();

        if (Physics.Raycast(raycastOrigin.position, raycastOrigin.TransformDirection(Vector3.forward), out hit, Mathf.Infinity, targetLayer))
        {
            Debug.Log($"<color=green>Hit target {hit.transform.name}");

            Target target = hit.transform.GetComponent<Target>();

            if (target != null)
            {
                target.TakeDamage(damage);
                targetName = hit.transform.name;
            }

            if (hit.rigidbody != null)
            {
                hit.rigidbody.AddForce(-hit.normal * impactForce);
            }
        }
    }
}
