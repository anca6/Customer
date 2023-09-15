using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{
    bool open;
    public Animator Animator;
    // Start is called before the first frame update
    void Start()
    {
        open = false;

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

        Animator.SetBool("Open",open);


    }
}
