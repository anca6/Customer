using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadEnding : MonoBehaviour
{
    public GameObject Camera;
    public GameObject Dissabled_Camera;
    public GameObject Dissabled_Camera2;
    public GameObject Player;
    public GameObject ElavatorSound;



    // Start is called before the first frame update
    void Start()
    {
        Camera.SetActive(false);
        ElavatorSound.SetActive(false);
       
    }

    // Update is called once per frame
    void Update()
    {
    }
    private void OnCollisionEnter(Collision Player)
    {
        Debug.Log("collsion");
        Camera.SetActive(true);
        Dissabled_Camera.SetActive(false);
        Dissabled_Camera2.SetActive(false);
        ElavatorSound.SetActive(true);
        



        /*  if (gameObject.CompareTag("Player"))
          { 
          Camera.SetActive(true);
          Debug.Log("second camera true");
          }
        */
    }
}
