using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Level : MonoBehaviour
{

    public RectTransform levels;
    float movingVariable = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (movingVariable >= -500)
        {

            MoveLeft();

        }

        if (movingVariable <= 0)
        {

           
            MoveRight();

        }

    }

    public void MoveLeft()
    {

        movingVariable = movingVariable - 250;
        levels.anchoredPosition = new Vector2(movingVariable, 0);

    }

    public void MoveRight()
    {

        movingVariable = movingVariable + 250;
        levels.anchoredPosition = new Vector2(movingVariable, 0);

    }
}
