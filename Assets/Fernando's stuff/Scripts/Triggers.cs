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
    
    private OpenWindows window;

    [SerializeField]
    private Interaction interactible;

    [SerializeField]
    private LockDoor door;

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

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Alarm"))
        {
            if (!interactible.isInteracted)
            {
                interactE.SetActive(true);
            }
        }

        if (collision.gameObject.CompareTag("Belonging"))
        {
                interactE.SetActive(true);
        }

        if (collision.gameObject.CompareTag("Door"))
        {
            interactE.SetActive(true);

            if (door.isClosed)
            {
                interactX.SetActive(true);
            }
        }

        if (collision.gameObject.CompareTag("Extinguisher"))
        {
            interactE.SetActive(true);

        }

    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Alarm"))
        {
            interactE.SetActive(false); 
        }

        if (collision.gameObject.CompareTag("Belonging"))
        {
            interactE.SetActive(false);
        }

        if (collision.gameObject.CompareTag("Door"))
        {
            interactE.SetActive(false);
            interactX.SetActive(false);
        }

        if (collision.gameObject.CompareTag("Extinguisher"))
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
