using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenWindows : MonoBehaviour
{
    public string boolTriggerName = "Open"; // variable that stores the stage of the animation
    public Animator[] animators; // array for animation stages 

    public int scoreChange = 1; // for reward system

    public GameObject IO; //InteractionObject

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player")) // if the player collides with the window
        {
            if (Input.GetKeyDown(KeyCode.E)) // if the activation key is pressed
            {
                if (animators == null || animators.Length == 0) // if there are no frames in the animation
                {
                    Debug.LogWarning("OpenWindows: Animator array empty!"); // error
                    return;
                }
                // open all
                bool currentState = animators[0].GetBool(boolTriggerName); // stores true/false if the window is open or not

                // type   varname  collectionname
                foreach (Animator anim in animators) // for all stages in the animation
                {
                    anim.SetBool(boolTriggerName, !currentState); // toggle all
                }

                if(currentState == true) // if the window is left open
                {
                    ScoreManager.Instance.ChangeScore(-scoreChange); // score: -1

                }

                else if(currentState == false) // if the window is left closed
                {
                    ScoreManager.Instance.ChangeScore(scoreChange); // score: +1
                }

                if (IO != null)
                {
                    Debug.LogWarning("no interaction object");
                    return;
                }
                Destroy(IO);
            }
            ScoreManager.Instance.GetScore(); // gets the final score
        }
    }
    
}
