using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reward : MonoBehaviour
{
    public GameObject background;
    public GameObject board;
    public GameObject left;
    public GameObject medium;
    public GameObject right;



    // Start is called before the first frame update
    void Start()
    {
        ScoreManager.Instance.GetScore();

        background.SetActive(false);
        board.SetActive(false);
        left.SetActive(false);
        medium.SetActive(false);
        right.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if(ScoreManager.Instance.GetScore() == 0)
        {

            background.SetActive(true);
            board.SetActive(true);

        }else if (ScoreManager.Instance.GetScore() == 1)
        {

            background.SetActive(true);
            board.SetActive(true);
            left.SetActive(true);

        }
        else if (ScoreManager.Instance.GetScore() == 2)
        {

            background.SetActive(true);
            board.SetActive(true);
            left.SetActive(true);
            medium.SetActive(true);

        }
        else if (ScoreManager.Instance.GetScore() == 3)
        {

            background.SetActive(true);
            board.SetActive(true);
            left.SetActive(true);
            medium.SetActive(true);
            right.SetActive(true);

        }
    }
}
