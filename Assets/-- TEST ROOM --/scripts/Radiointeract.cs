using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Radiointeract : MonoBehaviour
   
{
    // Start is called before the first frame update
    public GameObject RadioAudio;
    bool RadioAudioB;
    public GameObject OffClick;
    void Start()
    {
        RadioAudio.SetActive(true);
        RadioAudioB = true;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player")) // if the player collides with the radio
        {
            if (Input.GetKeyDown(KeyCode.E)) // if the activation key is pressed
            {
                if (!RadioAudioB)
                {
                    RadioAudio.SetActive(true);
                    RadioAudioB = true;
                    Debug.Log("radio on");
                }
                if (RadioAudioB)
                {
                    RadioAudio.SetActive(false);
                    RadioAudioB = false;
                    OffClick.SetActive(true);
                    Debug.Log("radio off");
                }
            }
        }
    }
}
