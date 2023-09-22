using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.UI;
using UnityEngine;

public class Fire_Extinguisher_animation : MonoBehaviour
{

    bool open;
    bool use;
    bool active;
    public GameObject On_And_Off;
    public GameObject Self;
    public float Animation_Durration;
    public float Delay;

    public Animator Animator;
    // Start is called before the first frame update
    void Start()
    {
        open = false;
        use = false;
        active = false;

 
    }

    // Update is called once per frame
    void Update()
    {
        /*
        //i saw paul do this to prevent stupid stuff from happneing. i don't know if return works how i think it works but it can't hurt.
        if (On_And_Off = null)
        {
            Debug.LogWarning("PARTICLE SYSTEM 1 NOT ASSIGHNED!!");
            return;
        }
         doens't work anyways
        */
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


        if (Input.GetKey(KeyCode.B)) // if B is pressed while the extinguisher is small use = true wich means the extinguishing animation can start playing
        {
            if (open)
            {
                use = true;
                Debug.Log("Use = " + use + Animator);
            }
        }
        // this plays the animation.
        if (use)
        {
           if (Animation_Durration > 0) // turns on the animation and starts a countdown to stop it
            {
                Animation_Durration -= Time.deltaTime;
                Debug.Log("ANIMATION_DURRATION COUNTER =  " +  Animation_Durration);
                Delay -=Time.deltaTime;
                if (Delay < 0)
                {
                    active = true;
                }

                // below is the particles turning on
               // active = true;
              /*
               * // On_And_Off2.SetActive(active);
                On_And_Off.SetActive(active); 
              */
               
                if (Animation_Durration < 0) //if the time given is over then it's no longer being used and get's returned to the "open" animaiton state (small)
                {
                    use = false;
                    active = false;
                    /* 
                     * //turning off particles
                      active = false;
                      On_And_Off.SetActive(active);
                     // On_And_Off2.SetActive(active); 
                    */
                    //destroying itself to prevent the player from using it again (this code is bad it will break when triggered mroe then once)
                    Self.SetActive(false);
                }
            }
        }
        On_And_Off.SetActive(active);
        Animator.SetBool("Open", open);
        Animator.SetBool("Use", use);

    }
}
