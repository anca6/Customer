using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Level : MonoBehaviour
{

    public RectTransform levels;
    public GameObject start;
    float movingVariable = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (movingVariable >= -1000)
        {

            MoveLeft();

        }

        if (movingVariable < 0)
        {

           
            MoveRight();

        }

        if(movingVariable == 0)
        {

            start.SetActive(true);

        }else
        {

            start.SetActive(false);

        }

    }

    public void MoveLeft()
    {

        movingVariable = movingVariable - 500;
        levels.anchoredPosition = new Vector2(movingVariable, 0);

    }

    public void MoveRight()
    {

        movingVariable = movingVariable + 500;
        levels.anchoredPosition = new Vector2(movingVariable, 0);

    }
}
