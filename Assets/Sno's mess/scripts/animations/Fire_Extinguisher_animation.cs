using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire_Extinguisher_animation : MonoBehaviour
{

    bool open;
    bool use;
    public float Animation_Durration;

    public Animator Animator;
    // Start is called before the first frame update
    void Start()
    {
        open = false;
        use = false;

    }

    // Update is called once per frame
    void Update()
    {
        //left mouse button to interacted state
        if (Input.GetMouseButtonDown(0))
        {
            open = true;
            Debug.Log("open = " + open + Animator);
        }
        //right mouse button change to default state

        if (Input.GetMouseButtonDown(1))
        {
            open = false;
            Debug.Log("open = " + open + Animator);
        }


        if (Input.GetKey(KeyCode.B))
        {
            if (open)
            {
                use = true;
                Debug.Log("Use = " + use + Animator);
            }
        }

        if (use)
        {
           if (Animation_Durration > 0)
            {
                Animation_Durration -= Time.deltaTime;
                Debug.Log("ANIMATION_DURRATION COUNTER =  " +  Animation_Durration);
                if (Animation_Durration < 0)
                {
                    use = false;
                }
            }
        }
        Animator.SetBool("Open", open);
        Animator.SetBool("Use", use);

    }
}
