using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class HydrantPickup : MonoBehaviour
{
    private bool interactedWith = false; // bool to set if a pickup has been interacted with or not
    public KeyCode ActivationKey = KeyCode.E; // activation key set to "E"

    public string pickupTag;
    public GameObject IO; //interactionObject
    public GameObject Audio;

    public float delay;

    bool open;
    bool use;
    bool active;
    public GameObject On_And_Off;
    public GameObject Self;
    public float Animation_Durration;
    public float Delay;
    public Animator Animator;

    private void Start()
    {
        open = false;
        use = false;
        active = false;
    }

    private void Update()
    {
        if (interactedWith)
        {
            open = true;
            Debug.Log("open = " + open + Animator);// plays animation

            delay -= Time.deltaTime; // delay before gameobject is destroye d to let animation play out.

            if (delay < 0) 
            { 
            /*
             * Destroy(gameObject); // if a pickup object has been interacted with, it gets destroyed
            //destroying the objet is a bad idea as i use it later. it's shrunken down so the colider shoudl shrink wiht it.
            */
            }
        }
        On_And_Off.SetActive(active);
        Animator.SetBool("Open", open);
        Animator.SetBool("Use", use);
    }

    private void OnCollisionStay(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player") && Input.GetKey(ActivationKey)) // if the player collides with the object and presses the activation key at the same type
        {
            PlayerInventory playerInventory = collision.gameObject.GetComponent<PlayerInventory>(); // finds the inventory component and creates an instance for reference
            /*if(playerInventory != null)
            {*/
                playerInventory.AddToInventory(pickupTag); // adds the pickup in the player inventory and stores it there
            
                interactedWith = true; // interacted is set to true

                Debug.Log(pickupTag + " grabbed"); // writes in the console which object was picked up




            //error catching 
            if (IO == null)
         
            {
                Debug.LogWarning("no interaction object");
                    return;
            }

            if (Audio == null)

            {
                Debug.LogWarning("no interaction audio");
                return;
            }
            Audio.SetActive(true);
            /* if (Audio = null)

             {
                 Debug.LogWarning("no interaction audio");
                 return;
             }
             Audio.SetActive(true); */
            Destroy(IO);
            
            //}

        }
    }
}
