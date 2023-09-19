using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenWindows : MonoBehaviour
{
    public string boolTriggerName = "Open";
    public Animator[] animators;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
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

                // type   varname  collectionname
                foreach (Animator anim in animators)
                {
                    anim.SetBool(boolTriggerName, !currentState); // toggle all
                }
            }
        }
    }
}