using UnityEngine;
using UnityEngine.UI;

public class EndScreen : MonoBehaviour
{
    public GameObject winPanel; 
    public GameObject losePanel; 

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (gameObject.CompareTag("Win"))
            {
                winPanel.SetActive(true); 
            }
            else if (gameObject.CompareTag("Lose"))
            {
                losePanel.SetActive(true); 
            }
        }
    }
}

