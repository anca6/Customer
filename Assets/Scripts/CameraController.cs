using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    private Transform targetTransform; //so we can take transform from another obj in editor (just drag in the obj to assign)

    private Vector3 originalPosition; //obj this is attached to original position
    private Quaternion originalRotation; //obj this is attached to original rotation
    private bool isToggled = false; //bool to check if we are on first or second camera position

    void Start()
    {
        //set originalPosition & originalRotation variable to obj this is attached to like take values
        originalPosition = transform.position;
        originalRotation = transform.rotation; 
    }

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.Y)) //if y is pressed
        {
            
            if (isToggled) //toggle between the initial position and the reference transform's position
            {
                //go back to the initial position & rotation
                transform.position = originalPosition;
                transform.rotation = originalRotation;
            }
            else
            {
                //move to the target transform position (from the obj)
                if (targetTransform != null) //check if its not null & actually assigned
                {
                    //set to the target position & rotation
                    transform.position = targetTransform.position;
                    transform.rotation = targetTransform.rotation;
                }
            }

            isToggled = !isToggled; //toggle the state
        }
    }



}
