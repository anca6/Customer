using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour
{
    public KeyCode ActivationKey = KeyCode.E; // activation key for interaction
    bool isInteracted = false; // checks if object has been interacted with

    private PlayerControls playerControls; // creates object that references the player movement script

    public string requiredPickupTag; // custom tag variable so one object can have an additional separate tag

    public int scoreChange = 1; // score value 
    //public bool increaseScore = true; 

    public GameObject IO; //InteractionObject
    public GameObject Audio;

    void Start()
    {
        playerControls = FindObjectOfType<PlayerControls>(); // finds player control component and sets it to this variable
    }

    private void OnCollisionStay(Collision collision)
    {
        PlayerInventory playerInventory = collision.gameObject.GetComponent<PlayerInventory>(); // creates instance of the player inventory to reference in this script

        //FIRE ALARM
        if (gameObject.CompareTag("Alarm"))
            if (isInteracted == false && Input.GetKey(ActivationKey)) // if the player interacts with the fire alarm
            {
                Debug.Log("test alarm");

                isInteracted = true; // so the player can only interact with it once
                ScoreManager.Instance.ChangeScore(scoreChange); // adds value to the big score variable

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
                Destroy(IO);
            }


        //PERSONAL BELONGINGS
        if (gameObject.CompareTag("Belonging"))
            if (isInteracted == false && Input.GetKey(ActivationKey)) // if the player interacts with a personal belonging
            {
                Debug.Log("test belonging");

                playerControls.AddCarry(2.5f); // adds "weight" to the player's speed - player slows down
                isInteracted = true;

                Destroy(gameObject); // we destroy it to simulate pickup animation
            }

        //FIRE OBSTACLE
        if(gameObject.CompareTag("Obstacle"))
            if(isInteracted == false && Input.GetKey(ActivationKey)) // if the player interacts with the obstacle - fire in front of the stairs' exit
            {
                if(playerInventory.inventory.Contains(requiredPickupTag)) // checks if the player has the fire extinguisher in its inventory
            {
                Debug.Log("test fire");

                isInteracted = true;

                Destroy(gameObject); // we destroy the obstacle so the player can access the exit door
            }
            }

    }
}
