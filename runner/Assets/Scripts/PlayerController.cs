using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;

    bool grounded = true;
    

    //jump coeffecient
    public float jump = 8f;
    private void Start()
    {
        //a call for the rigidbody
        rb = GetComponent<Rigidbody>();

        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump") && grounded)
        {
            // makes char jump
            rb.AddForce(transform.up * jump, ForceMode.Impulse);
            
            
            // grounding logic
            grounded = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "ground")
        {
            grounded = true;
        }
        
    }
}
