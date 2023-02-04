using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billboard : MonoBehaviour
{

    Vector3 cameraDir;


    private Quaternion originalRotation;

    private void Start()
    {
       // originalRotation = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        //transform.LookAt(Camera.main.transform.position, Vector3.up);
        //transform.rotation = camTransform.rotation * originalRotation;

        cameraDir = Camera.main.transform.forward;
        cameraDir.y = 0;

        transform.rotation = Quaternion.LookRotation(cameraDir);
    }
}
