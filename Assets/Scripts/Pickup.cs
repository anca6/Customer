using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    private bool interactedWith = false;
    public KeyCode ActivationKey = KeyCode.E;

    private void Update()
    {
        if (interactedWith)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player") && Input.GetKey(ActivationKey))
        {
            interactedWith = true;

            Debug.Log("Grabbed");
        }
    }
}
