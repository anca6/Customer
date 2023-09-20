using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ExitDetector : MonoBehaviour
{
    public UnityEvent forwardExit;
    public UnityEvent rearExit;

    private void OnTriggerExit(Collider other)
    {
        Vector3 directionVector = other.transform.position - transform.position;
        float exitDirection = Vector3.Dot(directionVector, transform.forward);
        Debug.Log(exitDirection);

        if (exitDirection > 0)
        {
            forwardExit.Invoke();
        }
        else
        {
            rearExit.Invoke();
        }
    }

}
