using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class Triggers : MonoBehaviour
{

    public GameObject interactE;
    public GameObject interactX;


    [SerializeField]
    private Pickup pickup;
    [SerializeField]
    private OpenWindows window;
    private Interaction interactible;

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

        if (other.gameObject.CompareTag("Window"))
        {
            interactE.SetActive(true);
        }
    }

    
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Key_UI"))
        {
            interactE.SetActive(false);
        }

        if (other.gameObject.CompareTag("Window"))
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
