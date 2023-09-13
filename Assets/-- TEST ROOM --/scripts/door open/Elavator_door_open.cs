using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elavator_door_open : MonoBehaviour

{
    bool open = false;
    bool has_run = false;
    int current_move = 0;
    public int max_move = 10000000;
    public int move_speed = 1000;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("script running");
        Debug.Log(open);
    }

    // Update is called once per frame
    void Update()
    { 
        //  Debug.Log("still running");

        //checks if the mousebutton has been pressed and sets "open" to true.
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("door is open");
            open = true;
        }
        //if open = true open the door

        if (open)
        {
            if (has_run == false)
            {
                if (current_move < max_move)
                {
                    transform.Translate (new Vector3(0, move_speed, 0));
                    Debug.Log(current_move + move_speed);
                   
           
                    //current_move + move_speed; //< not working changed for current_move ++

                    current_move++;


                }
                if (current_move == max_move)
                {
                    has_run = true;
                }
            }
        }
    }
}

