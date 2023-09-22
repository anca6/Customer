using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MovetempV2 : MonoBehaviour
{
    public float speed = 2.0f;
    public GameObject character;

    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame

    void FixedUpdate()
    {
        Vector3 moveVec = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")) * speed;
            rb.AddForce(moveVec * speed);

            rb.AddForce(transform.forward * speed * moveVec.z);
            rb.AddForce(transform.right * speed * moveVec.x);
    }
}

