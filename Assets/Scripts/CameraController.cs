using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    private List<Transform> targetTransforms = new List<Transform>(); // List of target positions & rotations

    [SerializeField]
    private float transitionDuration = 2.0f; // Transition duration

    private int currentTarget = 0; // Keep track of which target we are at
    private bool isTransitioning = false;

    void Start()
    {
        SetCameraToCurrentTarget(); // Start off with the camera position/rotation of the current object this script is attached to
    }

    private void Update()
    {
        if (isTransitioning)
            return; // Exit the current method from executing

        if (Input.GetKeyDown(KeyCode.Y))
        {
            SetNextTarget(); // Go to the next target position/rotation
        }
    }

    private void SetCameraToCurrentTarget()
    {
        if (currentTarget >= 0 && currentTarget < targetTransforms.Count)
        { // Check if currentTarget is a valid number in targetTransforms list
            transform.position = targetTransforms[currentTarget].position; // Set current position to the object this script is attached to
            transform.rotation = targetTransforms[currentTarget].rotation; // Set current rotation to the object this script is attached to
        }
    }

    private void SetNextTarget()
    { // Go to the next target position/rotation from the list
        if (isTransitioning)
            return; // Exit the current method from executing

        currentTarget = (currentTarget + 1) % targetTransforms.Count; // Calculate the number of the next target, looping around the list if needed
        StartCoroutine(TransitionCamera(targetTransforms[currentTarget])); // Start transitioning to the next target 
    }

    IEnumerator TransitionCamera(Transform targetTransform)
    {
        isTransitioning = true;
        float t = 0.0f;

        Vector3 startingPosition = transform.position; // Set start position to current position (the object this script is attached to)
        Quaternion startingRotation = transform.rotation; // Set start rotation to current rotation (the object this script is attached to)

        while (t < 1.0f)
        {
            t += Time.deltaTime / transitionDuration; // Increment t based on time passed and transition duration for smooth interpolation

            transform.position = Vector3.Lerp(startingPosition, targetTransform.position, t); // Move from current position to target position with duration of t
            transform.rotation = Quaternion.Slerp(startingRotation, targetTransform.rotation, t); // Rotate from current rotation to target rotation with duration of t

            yield return null; // Wait until the next frame before continuing the loop
        }
        isTransitioning = false;
    }
}
