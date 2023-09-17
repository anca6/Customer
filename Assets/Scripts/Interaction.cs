using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour
{
    public KeyCode ActivationKey = KeyCode.E;
    bool isInteracted = false;

    private PlayerControls playerControls;

    public string requiredPickupTag;

    void Start()
    {
        playerControls = FindObjectOfType<PlayerControls>();
    }

    private void OnCollisionStay(Collision collision)
    {
        PlayerInventory playerInventory = collision.gameObject.GetComponent<PlayerInventory>();

        //FIRE ALARM
        if (gameObject.CompareTag("Alarm"))
            if (isInteracted == false && Input.GetKey(ActivationKey))
            {
                Debug.Log("test alarm");
                //TO DO: add audio effect
                //TO DO: deactivate glowy mesh?
                isInteracted = true;
            }

        //WINDOW
        if (gameObject.CompareTag("Window"))
            if (isInteracted == false && Input.GetKey(ActivationKey))
            {
                Debug.Log("test window");
                //TO DO: add audio effect
                //TO DO: add animation
                isInteracted = true;
            }

        //PERSONAL BELONGINGS
        if (gameObject.CompareTag("Belonging"))
            if (isInteracted == false && Input.GetKey(ActivationKey))
            {
                Debug.Log("test belonging");

                playerControls.AddCarry(2.5f);
                isInteracted = true;

                Destroy(gameObject);
            }

        //FIRE OBSTACLE
        if(gameObject.CompareTag("Obstacle"))
            if(isInteracted == false && Input.GetKey(ActivationKey))
            {
                if(playerInventory.inventory.Contains(requiredPickupTag))
            {
                Debug.Log("test fire");

                isInteracted = true;

                Destroy(gameObject);
            }
            }

    }
    // Update is called once per frame
    void Update()
    {

    }
}
