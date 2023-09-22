using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ElavatorOpen : MonoBehaviour
{
    bool open;
    public KeyCode ActivationKey = KeyCode.E;
    public Animator Animator;
    public GameObject ElavatorSound;
    bool use;
    bool active;
    public GameObject On_And_Off;
    public GameObject Self;
    public float Animation_Durration;
    public float Delay;

    //public UnityEvent endCamera;
    // Start is called before the first frame update
    void Start()
    {
        open = false;
        Animator.SetBool("Open", open);
        ElavatorSound.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    
    private void OnCollisionStay(Collision Player)
    {
        Debug.Log("collsion elavator");
        if (Input.GetKeyDown(ActivationKey)) // if the player collides with the object and presses the activation key at the same type
        {
            open = true;
            Debug.Log("input detected");
            Animator.SetBool("Open", open);
            ElavatorSound.SetActive(true);

            //endCamera.Invoke();
        }
    }
    
}
