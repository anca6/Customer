using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dooropenonclick : MonoBehaviour
{
    bool open = false;
    bool has_run = false;
    int current_rotate = 0;
   public int max_rotate = 90;
    public int rotate_speed = 1;
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
                if (current_rotate < max_rotate)
                {
                    transform.Rotate(0, rotate_speed, 0, Space.Self);
                    Debug.Log(current_rotate + rotate_speed);
                    //current_rotate + rotate_speed; <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<< I don't need to know this but could you tell me why it's not working? 
                    //temp solution below
                    current_rotate++;
                        
                  
                }
                if (current_rotate == max_rotate)
                {
                    has_run = true;
                }    
            }
        }


    
     
    }
}
