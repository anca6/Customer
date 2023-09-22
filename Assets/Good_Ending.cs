using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Good_Ending : MonoBehaviour
{
    public GameObject Camera;
    public GameObject Dissabled_Camera;
    public GameObject Dissabled_Camera2;
    public GameObject Player;
    public GameObject background;
    public GameObject board;
    public GameObject left;
    public GameObject medium;
    public GameObject right;
    public GameObject self;
    public GameObject menu;
    public GameObject FireAlarm;


    public GameObject VictorySound;
    public float Delay;
    bool winner;
    // Start is called before the first frame update
    void Start()
    {
        Camera.SetActive(false);

       
        VictorySound.SetActive(false);

        ScoreManager.Instance.GetScore();

        background.SetActive(false);
        board.SetActive(false);
        left.SetActive(false);
        medium.SetActive(false);
        right.SetActive(false);
        menu.SetActive(false);

    }

    private void CheckScore()
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

    // Update is called once per frame
    void Update()
    {
        if (winner)
        {
            Delay -= Time.deltaTime;
            if (Delay <= 0 )
            {
                VictorySound.SetActive(true);
                FireAlarm.SetActive(false);
                self.SetActive(false);
                CheckScore();



            }
        }
    }
  
    private void OnCollisionEnter(Collision Player)
    {
        Debug.Log("collsion");
        Camera.SetActive(true);
        Dissabled_Camera.SetActive(false);
        Dissabled_Camera2.SetActive(false);
      
        winner = true;

       

    }

    
}
