using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Office_Door_Left_o : MonoBehaviour
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
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("left door is open");
            open = true;
        }
        Animator.SetBool("left_open", open);
    }
}
