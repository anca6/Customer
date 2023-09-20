using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTriggers : MonoBehaviour
{
    public bool isTriggered;
    private int currentCamera = 0;
    private CameraController cameraController;

    private void Start()
    {
        cameraController = GameObject.FindObjectOfType<CameraController>();
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(gameObject.tag);

        if (gameObject.CompareTag("OfficeTrigger"))
        {
            if (other.gameObject.CompareTag("Player") && currentCamera != 0)
            {
                isTriggered = false;
                cameraController.isToggled = true;
                currentCamera = 0;
                Debug.Log(" isTriggered: " + isTriggered);
            }

        }

        if (gameObject.CompareTag("HallwayTrigger"))
        {
            if (other.gameObject.CompareTag("Player") && currentCamera != 1)
            {
                isTriggered = true;
                cameraController.isToggled = true;
                currentCamera = 1;
                Debug.Log("isTriggered 1: " + isTriggered);
            }
            else if (other.gameObject.CompareTag("Player") && currentCamera == 1)
            {
                // If already on the hallway camera, switch to the office camera
                isTriggered = false;
                cameraController.isToggled = true;
                currentCamera = 0;
                Debug.Log("isTriggered 0:" + isTriggered);
            }

        }
    }
}
//make only one trigger object in the doorstep and store the location of the player (x coordonate). and check if the x of the player is > x of trigger then
//hallway camera is enabled. if the x of the player is < than the x of the trigger then the main camera is enabled. so we enable either of those 2 cameras 
