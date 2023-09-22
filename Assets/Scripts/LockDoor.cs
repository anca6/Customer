using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockDoor : MonoBehaviour
{
    public KeyCode ActivationKey = KeyCode.E; // activation key
    public KeyCode LockKey = KeyCode.X; // lockind door key

    public string requiredPickupTag;

    public float cooldownSeconds = 1; // cooldown so we dont spam keys

    public bool isClosed = true;
    public bool isLocked = false;

    int lastScore = 0;

    float nextActionTime; // for the cooldown

    public Animation doorAnimation; // to call the animation

    public int scoreChange = 1; // score value that changes score

    public GameObject Audio;

    private void Start()
    {
        CheckScore();
    }

    void CheckScore()
    {
        Debug.Log("Door: Checking whether score should change");
        int correctScore = (isClosed && !isLocked) ? 1 : 0;
        if (correctScore != lastScore)
        {
            ScoreManager.Instance.ChangeScore(correctScore - lastScore);
            Debug.Log("Updating score for door: " + (correctScore - lastScore));
            Debug.Log("Score is now: " + ScoreManager.Instance.GetScore());
            lastScore = correctScore;
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            PlayerInventory playerInventory = collision.gameObject.GetComponent<PlayerInventory>(); // references the player inventory

            if (Input.GetKey(ActivationKey)) // if the player presses the activation key
            {
                if (Time.time > nextActionTime) // if the player can actually press that key
                {
                    if (isClosed && !isLocked) // pretty self explanatory
                    {
                        isClosed = false; // the door is open
                        Debug.Log("Open");

                        //trigger open animation
                        doorAnimation.Open();


                        if (Audio == null)

                        {
                            Debug.LogWarning("no interaction audio");
                            return;
                        }
                        Audio.SetActive(true);
                        CheckScore();
                    }

                    else if (!isClosed)
                    {
                        isClosed = true; // the door is closed
                        Debug.Log("Closed");

                        //trigger close animation
                        doorAnimation.Close();

                        CheckScore();

                    }
                    nextActionTime = Time.time + cooldownSeconds; // sets the time the player can acivate anything with the keys
                }
                else
                {
                    //Debug.Log("DENIED!");
                }

            }
            if (playerInventory != null) // if the player has picked up objects in the inventory
            {
                if (Input.GetKey(LockKey)) // if they want to lock the door
                {
                    if (Time.time > nextActionTime) // if they can actually lock the door
                    {
                        if (isClosed && !isLocked && playerInventory.inventory.Contains(requiredPickupTag)) // if the door is closed and they have the key in inventory
                        {
                            isLocked = true; // door is locked
                            Debug.Log("Locked!");

                            CheckScore();
                        }
                        else if (isClosed && isLocked && playerInventory.inventory.Contains(requiredPickupTag)) // if the door is closed, locked and they have the key
                        {
                            isLocked = false; // door is unlocked
                            Debug.Log("Unlocked!");

                            CheckScore();
                        }
                        nextActionTime = Time.time + cooldownSeconds; // sets the time the player can acivate anything with the keys
                    }
                    else
                    {
                        //Debug.Log("DENIED!");
                    }
                }
            }

        }
        ScoreManager.Instance.GetScore(); // gets the big score variable

    }

}
