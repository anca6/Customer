using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Good_Ending : MonoBehaviour
{
    public GameObject Camera;
    public GameObject Dissabled_Camera;
    public GameObject Dissabled_Camera2;
    public GameObject Player;

    public GameObject VictorySound;
    public float Delay;
    bool winner;
    // Start is called before the first frame update
    void Start()
    {
        Camera.SetActive(false);
       
        VictorySound.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (winner)
        {
            Delay -= Time.deltaTime;
            if (Delay <= 0 )
            {
                VictorySound.SetActive(true);
            }
        }
    }
    private void OnCollisionEnter(Collision Player)
    {
        Debug.Log("collsion");
        Camera.SetActive(true);
        Dissabled_Camera.SetActive(false);
        Dissabled_Camera2.SetActive(false);
      
        winner = true;




        /*  if (gameObject.CompareTag("Player"))
          { 
          Camera.SetActive(true);
          Debug.Log("second camera true");
          }
        */
    }
}
