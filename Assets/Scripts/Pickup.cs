using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    private bool interactedWith = false;
    public KeyCode ActivationKey = KeyCode.E;

    public string keyTag = "Key"; //Tag for the key item
    public string extinguisherTag = "Extinguisher"; //Tag for the extinguisher item

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
            PlayerInventory playerInventory = collision.gameObject.GetComponent<PlayerInventory>();
            if(playerInventory != null && playerInventory.inventory.Contains(keyTag))
            {
                interactedWith = true;

                Debug.Log("Key grabbed");
            }

            if (playerInventory != null && playerInventory.inventory.Contains(extinguisherTag))
            {
                interactedWith = true;

                Debug.Log("Extnguisher grabbed");
            }

        }
    }
}
