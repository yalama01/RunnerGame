using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    

    //jump coeffecient
    public float jump = 2f;
    private void Start()
    {
        //a call for the rigidbody
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            rb.AddForce(transform.up * jump, ForceMode.Impulse);
        }
        
    }
}
