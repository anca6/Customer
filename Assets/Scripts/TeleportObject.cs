using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportObject : MonoBehaviour
{
    public Transform teleportLocation;
    public KeyCode ActivationKey = KeyCode.R;

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && Input.GetKey(ActivationKey))
        {
            TeleportPlayer(other.gameObject);
            /*Debug.Log("Teleported");
            other.gameObject.transform.position = teleportLocation.position;*/
        }
    }

    private void TeleportPlayer(GameObject player)
    {
        LockDoor doorScript = GetComponentInParent<LockDoor>();

        if (doorScript != null && !doorScript.isClosed)
        {
            player.transform.position = teleportLocation.position;
            Debug.Log("Teleported.");
        }
        else
        {
            Debug.Log("You cannot teleport through a closed or locked door.");
        }
    }
}
