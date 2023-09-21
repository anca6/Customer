using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    public float moveSpeed = 5f;

    public float maxCarryAmount = 10;
    float carrying = 0; //in kgs

    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalinput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(-horizontalinput, 0f, -verticalInput);
        rb.velocity = movement * moveSpeed * Mathf.Clamp((1 - carrying / maxCarryAmount), 0, 1);

        if (movement.magnitude > 0)
        {
            var Target = Mathf.Atan2(movement.x, movement.z) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0.0f, Target, 0.0f);
        }
    }

    public void AddCarry(float kgs)
    {
        carrying += kgs;
        return;
    }
}
