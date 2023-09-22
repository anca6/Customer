using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TEMPMOUSELOOK : MonoBehaviour
{

    [SerializeField]
    private float mouseSpeed = 0.5f;
    Vector3 turn;

    [SerializeField]
    private float maxYAngle = 60;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; // makes mouse go in the game
    }

    // Update is called once per frame
    void Update()
    {
        turn.y -= Input.GetAxis("Mouse Y") * mouseSpeed;
        turn.x += Input.GetAxis("Mouse X") * mouseSpeed;
    }

    private void FixedUpdate()
    {
        turn.y = Mathf.Clamp(turn.y, -maxYAngle, maxYAngle);
        transform.localRotation = Quaternion.Euler(turn.y, turn.x, 0);
    }
}

