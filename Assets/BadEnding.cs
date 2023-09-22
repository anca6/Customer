using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadEnding : MonoBehaviour
{
    public GameObject Camera;
    public GameObject Dissabled_Camera;
    public GameObject Dissabled_Camera2;
    public GameObject Player;
    public GameObject ElavatorSound;
    public GameObject background;
    public GameObject board;
    public GameObject left;
    public GameObject medium;
    public GameObject right;
    public GameObject menu;
    public GameObject FireAlarm;

    public int scoreChange = 0;

    // Start is called before the first frame update
    void Start()
    {
        Camera.SetActive(false);
        ElavatorSound.SetActive(false);

        ScoreManager.Instance.GetScore();

        background.SetActive(false);
        board.SetActive(false);
        left.SetActive(false);
        medium.SetActive(false);
        right.SetActive(false);
        menu.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision Player)
    {
        Debug.Log("collsion");
        Camera.SetActive(true);
        Dissabled_Camera.SetActive(false);
        Dissabled_Camera2.SetActive(false);
        ElavatorSound.SetActive(true);

        ScoreManager.Instance.SetScore(scoreChange);

        Invoke("CheckScore", 5);
        FireAlarm.SetActive(false);
    }

    void CheckScore()
    {
        if (ScoreManager.Instance.GetScore() == 0)
        {
            Debug.Log("test score manager");
            background.SetActive(true);
            board.SetActive(true);
            menu.SetActive(true);

        }
        else if (ScoreManager.Instance.GetScore() == 1)
        {

            background.SetActive(true);
            board.SetActive(true);
            left.SetActive(true);
            menu.SetActive(true);

        }
        else if (ScoreManager.Instance.GetScore() == 2)
        {

            background.SetActive(true);
            board.SetActive(true);
            left.SetActive(true);
            medium.SetActive(true);
            menu.SetActive(true);

        }
        else if (ScoreManager.Instance.GetScore() == 3)
        {

            background.SetActive(true);
            board.SetActive(true);
            left.SetActive(true);
            medium.SetActive(true);
            right.SetActive(true);
            menu.SetActive(true);

        }
    }
}
