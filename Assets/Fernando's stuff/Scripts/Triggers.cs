using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class Triggers : MonoBehaviour
{

    public GameObject interactE;
    public GameObject interactX;

    public string requiredTag;

    [SerializeField]
    private Pickup pickup;

    void Start()
    {

        interactE.SetActive(false);
        interactX.SetActive(false);


    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Key_UI"))
        {
            if (!pickup.interactedWith)
            {
                interactE.SetActive(true);
            }
            
        }
        
    }
    

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Key_UI"))
        {
            interactE.SetActive(false);
        }
    }

    private void Update()
    {
        if (pickup.interactedWith)
        {
            interactE.SetActive(false);
        }
    }

}
