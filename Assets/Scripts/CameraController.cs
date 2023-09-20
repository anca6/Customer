using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    private Transform targetTransform; //so we can take transform from another obj in editor (just drag in the obj to assign)

    private Vector3 originalPosition; //obj this is attached to original position
    private Quaternion originalRotation; //obj this is attached to original rotation

    private Vector3 originalOffset;

    private CameraTriggers cameraTriggers;

    public bool isToggled = false;

    private Transform cameraTransform; // Reference to the camera's transform
    private Transform playerTransform;

    void Start()
    {
        originalOffset = transform.position - targetTransform.position;
        //set originalPosition & originalRotation variable to obj this is attached to like take values
        originalPosition = transform.position;
        originalRotation = transform.rotation;


        cameraTriggers = GameObject.FindObjectOfType<CameraTriggers>();

        cameraTransform = transform;
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }


    private void Update()
    {
        Debug.Log($"isTriggered {cameraTriggers.isTriggered} isToggled {isToggled} targetTransform {targetTransform}");

        if (cameraTriggers.isTriggered == true && isToggled)
        {
            //go back to the initial position & rotation


            transform.position = originalPosition - originalOffset;
            transform.rotation = originalRotation;
            isToggled = false;
        }
        if (cameraTriggers.isTriggered == false && isToggled)
        {
            //move to the target transform position (from the obj)
            if (targetTransform != null) //check if its not null & actually assigned
            {

                //set to the target position & rotation
                transform.position = targetTransform.position;
                transform.rotation = targetTransform.rotation;
                isToggled = false;
            }
        }
    }



}
