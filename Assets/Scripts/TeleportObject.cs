using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportObject : MonoBehaviour
{
    public Transform teleportLocation;
    public KeyCode ActivationKey = KeyCode.E;

    private void OnCollisionStay(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player") && Input.GetKey(ActivationKey))
        {
            Debug.Log("Teleported");
            collision.gameObject.transform.position = teleportLocation.position;
        }
    }
}
