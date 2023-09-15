using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockDoor : MonoBehaviour
{
    public KeyCode ActivationKey = KeyCode.E;
    public KeyCode LockKey = KeyCode.X;

    public string keyTag = "Key";
    public string exinguisherTag = "Extinguisher";

    public float cooldownSeconds = 1;

    public bool isClosed = true;
    bool isLocked = false;

    float nextActionTime;


    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            PlayerInventory playerInventory = other.gameObject.GetComponent<PlayerInventory>();

                if (Input.GetKey(ActivationKey))
                {
                    if (Time.time > nextActionTime)
                    {
                        if (isClosed && !isLocked)
                        {
                            isClosed = false;
                            Debug.Log("Open");
                        }
                        else if (!isClosed)
                        {
                            isClosed = true;
                            Debug.Log("Closed");
                        }
                        nextActionTime = Time.time + cooldownSeconds;
                    }
                    else
                    {
                        //Debug.Log("DENIED!");
                    }
                }
            if (playerInventory != null)
            {
                if (Input.GetKey(LockKey))
                {
                    if (Time.time > nextActionTime)
                    {
                        if (isClosed && !isLocked && playerInventory.inventory.Contains(keyTag))
                        {
                            isLocked = true;
                            Debug.Log("Locked!");
                        }
                        else if (isClosed && isLocked && playerInventory.inventory.Contains(keyTag))
                        {
                            isLocked = false;
                            Debug.Log("Unlocked!");
                        }
                        nextActionTime = Time.time + cooldownSeconds;
                    }
                    else
                    {
                        //Debug.Log("DENIED!");
                    }
                }
            }
        }
        buttonPressed = false;
    }

    bool buttonPressed = false;

    // Update is called once per frame
    void Update()
    {
        //if() buttonPressed = true;

    }
}
