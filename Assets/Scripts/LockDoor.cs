using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockDoor : MonoBehaviour
{
    public KeyCode ActivationKey = KeyCode.E;
    public KeyCode LockKey = KeyCode.X;

    public string requiredPickupTag;

    public float cooldownSeconds = 1;

    public bool isClosed = true;
    bool isLocked = false;

    float nextActionTime;

    public Animation doorAnimation;

    public int scoreChange = 1;

    bool openScore;
    bool closeScore;
    bool lockScore;
    bool unlockScore;


    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            PlayerInventory playerInventory = collision.gameObject.GetComponent<PlayerInventory>();

            if (Input.GetKey(ActivationKey))
            {
                if (Time.time > nextActionTime)
                {
                    if (isClosed && !isLocked)
                    {
                        isClosed = false;
                        Debug.Log("Open");

                        //trigger open animation
                        doorAnimation.Open();
                        openScore = true;

                        //ScoreManager.Instance.GetScore();

                    }
                    else if (!isClosed)
                    {
                        isClosed = true;
                        Debug.Log("Closed");

                        //trigger close animation
                        doorAnimation.Close();
                        closeScore = true;
                        ScoreManager.Instance.ChangeScore(scoreChange);

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
                        if (isClosed && !isLocked && playerInventory.inventory.Contains(requiredPickupTag))
                        {
                            isLocked = true;
                            Debug.Log("Locked!");
                            lockScore = true;
                        }
                        else if (isClosed && isLocked && playerInventory.inventory.Contains(requiredPickupTag))
                        {
                            isLocked = false;
                            Debug.Log("Unlocked!");
                            unlockScore = true;
                        }
                        nextActionTime = Time.time + cooldownSeconds;
                    }
                    else
                    {
                        //Debug.Log("DENIED!");
                    }
                }
            }
            if(closeScore && unlockScore)
            {
                ScoreManager.Instance.ChangeScore(scoreChange);
            }
            /*else if(openScore)
            {
                ScoreManager.Instance.ChangeScore(-scoreChange);
            }*/
        }
        ScoreManager.Instance.GetScore();
        buttonPressed = false;
    }

    bool buttonPressed = false;

    // Update is called once per frame
    void Update()
    {
        

    }
}
