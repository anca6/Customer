using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doormat : MonoBehaviour
{
    public KeyCode ActivationKey = KeyCode.E; // activation key
    public KeyCode LockKey = KeyCode.X; // lockind door key

    public string requiredPickupTag;

    public float cooldownSeconds = 1; // cooldown so we dont spam keys

    //public bool isClosed = true;
    bool Extinguished = false;

    float nextActionTime; // for the cooldown

    //public Animation doorAnimation; // to call the animation

   // public int scoreChange = 1; // score value that changes score

    // reward system checks
   /* bool openScore;
    bool closeScore;
    bool lockScore;
    bool unlockScore;
   */
    public GameObject Audio;
    public GameObject self;


    private void OnCollisionStay(Collision collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {
            PlayerInventory playerInventory = collision.gameObject.GetComponent<PlayerInventory>(); // references the player inventory
            /*
            if (Input.GetKey(ActivationKey)) // if the player presses the activation key

            {
                Destroy(self);
            }
                /*
                if (Time.time > nextActionTime) // if the player can actually press that key
                {
                    
                        isClosed = false; // the door is open
                        Debug.Log("Open");

                        //trigger open animation
                       // doorAnimation.Open();
                        openScore = true; // for reward system

                        if (Audio == null)

                        {
                            Debug.LogWarning("no interaction audio");
                            return;
                        }
                        Audio.SetActive(true);
                

                     if (!isClosed)
                    {
                        isClosed = true; // the door is closed
                        Debug.Log("fire");

                        //trigger close animation
                        ///doorAnimation.Close();
                        //closeScore = true;
                        //ScoreManager.Instance.ChangeScore(scoreChange);

                    }
                    nextActionTime = Time.time + cooldownSeconds; // sets the time the player can acivate anything with the keys
                }
                /*
               else
                {
                    //Debug.Log("DENIED!");
                }

                //IN PROGRESS
                /*
                if (closeScore && unlockScore)
                {
                    ScoreManager.Instance.ChangeScore(scoreChange);
                }
                               
            }





            */
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////








            if (playerInventory != null) // if the player has picked up objects in the inventory
            {
                if (Input.GetKey(LockKey)) // if they want to lock the door
                {
                    
                        if (!Extinguished && playerInventory.inventory.Contains(requiredPickupTag)) // if the door is closed and they have the key in inventory
                        {
                            Extinguished = true; // door is locked
                            Debug.Log("no more fire");
                           // lockScore = true; // for reward system
                        }
                        /*else if (isClosed && isLocked && playerInventory.inventory.Contains(requiredPickupTag)) // if the door is closed, locked and they have the key
                        {
                            isLocked = false; // door is unlocked
                            Debug.Log("fire");
                            unlockScore = true; // for reward system
                        }
                        */
                        //nextActionTime = Time.time + cooldownSeconds; // sets the time the player can acivate anything with the keys
                    }
                    /*else
                    {
                        //Debug.Log("DENIED!");
                    }
                */
            }
            /*if(closeScore && unlockScore)
            {
                ScoreManager.Instance.ChangeScore(scoreChange);
            }
            else if (openScore)
            {
                ScoreManager.Instance.ChangeScore(-scoreChange);
            }*/
        }
        //ScoreManager.Instance.GetScore(); // gets the big score variable
        //buttonPressed = false; // dw about this
    }
}

    //bool buttonPressed = false; // dw about this
