using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int playerScore = 0;

    public static ScoreManager Instance;
    // Start is called before the first frame update
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

    public void ChangeScore(int scoreChange)
    {
        playerScore += scoreChange;
        Debug.Log(playerScore);
    }

    public int GetScore()
    {
        return playerScore;
    }
   
}
