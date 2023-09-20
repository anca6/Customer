using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ExitDetector : MonoBehaviour
{
    public UnityEvent forwardExit; // event for entrance to the hallway
    public UnityEvent rearExit; // event for entrance to the office

    private void OnTriggerExit(Collider other)
    {
        // calculates the difference between player position and object position
        Vector3 directionVector = other.transform.position - transform.position; 
        float exitDirection = Vector3.Dot(directionVector, transform.forward); 
        Debug.Log(exitDirection);

        if (exitDirection > 0) // if the player goes through the door and reaches the hallway's side
        {
            forwardExit.Invoke(); // second camera: enabled and main camera:disabled
        }
        else // if the player goes through the door and reaches the office's side
        {
            rearExit.Invoke(); // second camera:disabled and main camera:enabled
        }
    }

}
