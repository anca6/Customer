using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class suspensetimer : MonoBehaviour
{
    public float delay;
    public GameObject CalmMusic;
    public GameObject SuspenseMusic;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        delay -= Time.deltaTime;
        if (delay < 0 )
        {
            SuspenseMusic.SetActive( true );
            CalmMusic.SetActive( false );
        }

    }
}
