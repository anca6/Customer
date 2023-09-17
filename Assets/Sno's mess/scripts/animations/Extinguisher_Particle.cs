using System.Collections;
using System.Collections.Generic;
using UnityEditor.Search;
using UnityEngine;

public class Extinguisher_Particle : MonoBehaviour
{
    public GameObject OnAndOff;
    bool Active;
    // Start is called before the first frame update
    void Start()
    {
       Active = false;
        OnAndOff.SetActive(Active);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            Active = false;
            OnAndOff.SetActive(Active);
        }

        if (Input.GetMouseButton(1))
        {
            Active = true;
            OnAndOff.SetActive(Active);
        }



        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /*
         //taken from https://stackoverflow.com/questions/4307467/what-does-var-mean-in-c

        var emission = ParticleSystem.emission; // Stores the module in a local variable
        emission.enabled = true; // Applies the new value directly to the Particle System
        */


        /*
         //when a mouse button is pressed set the emmsion of the particle system to 0 or to public int emmision
         if (Input.GetMouseButtonDown(0))
         {
             GetComponent<ParticleSystem>().Emit(0);
             Debug.Log("particle off");
         }

         if (Input.GetMouseButtonDown(1))
         {
             GetComponent<ParticleSystem>().Emit(emission);
             Debug.Log("particle on");
         }

         //original emmision of the big stream is 150-100

         //orignal emmision of the small stream is 20-5
        */
    }
}
