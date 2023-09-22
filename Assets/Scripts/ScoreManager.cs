using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int playerScore = 0; // score initiated with 0

    public static ScoreManager Instance; // creates instance of the score manager which can be referenced from any script

    // sets instance of object to score manager
    private void Awake() 
    {
        if(Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // this changes the score and allows each script to have a different scoreChange value
    public void ChangeScore(int scoreChange)
    {
        playerScore += scoreChange;
        Debug.Log(playerScore);
    }

    // this gets the updated score value
    public int GetScore()
    {
        return playerScore;
    }

    public void SetScore(int scoreChange)
    {
        playerScore = scoreChange;
        Debug.Log(playerScore);
    }

}
