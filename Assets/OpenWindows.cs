using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenWindows : MonoBehaviour
{
    public string boolTriggerName = "Open";
    public Animator[] animators;
    public GameObject InteractionIndicator;

    public int scoreChange = 1;

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (animators == null || animators.Length == 0)
                {
                    Debug.LogWarning("OpenWindows: Animator array empty!");
                    return;
                }
                // open all
                bool currentState = animators[0].GetBool(boolTriggerName);
                //destroys indicator
                if (InteractionIndicator != null)
                {
                    Debug.LogWarning("OBJECT HAS NO INTERACTION INDICATOR ASSIGHNED ");
                    return;
                }
                Destroy(InteractionIndicator);

                // type   varname  collectionname
                foreach (Animator anim in animators)
                {
                    anim.SetBool(boolTriggerName, !currentState); // toggle all
                }

                if(currentState == true)
                {
                    ScoreManager.Instance.ChangeScore(-scoreChange);
                }

                else if(currentState == false)
                {
                    ScoreManager.Instance.ChangeScore(scoreChange);
                }
            }
            ScoreManager.Instance.GetScore();
        }
    }
    
}
