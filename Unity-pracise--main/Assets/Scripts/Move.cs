using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Move : MonoBehaviour
{
    public float speed;// speed for move 
    private Rigidbody rigidbody; // Component rigidbody
    public float jump;// jump for move 
    private AudioSource source; // added audio component 

    // Start is called before the first frame update
    public void Start()
    {
        rigidbody = GetComponent<Rigidbody>(); // sharing values component between rigidbody & Rigidbody's component 
        source = GetComponent<AudioSource>();// sharing values component between source & AudioSource's component  
    }

    // Update is called once per frame
    public void Update()
    {
        Jump();
    }
    //FixedUpdate is calles more than once per frame 
    public void FixedUpdate()
    {
        rigidbody.AddForce(new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")) * speed);  // method for move 
    }
    public void Jump() { //Jump is called that method for jump
        try
        {
            if (Input.GetButtonDown("Jump") && Mathf.Abs(rigidbody.velocity.y) < 0.01f)
            { // condition for get value a buttons for method jump and added velocity into y 
                rigidbody.AddForce(Vector3.up * jump, ForceMode.Impulse);
                source.Play();
                Debug.Log("Jump!");
            }
        }
        catch (Exception ex) {
            Debug.Log(ex + "Error!"); // checking if we have a problems 
        }
    }
}
