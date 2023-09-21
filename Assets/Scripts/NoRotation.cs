using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoRotation : MonoBehaviour
{
    private Quaternion cameraRotation;
    void Start()
    {
        cameraRotation = this.transform.rotation;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        this.transform.rotation = cameraRotation;
    }
}
