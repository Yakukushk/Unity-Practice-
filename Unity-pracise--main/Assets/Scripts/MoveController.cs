using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveController : MonoBehaviour
{
    Rigidbody rb;
    float speed = 5f;
    public float jump = 5f;
    public CharacterController controller;
    public float gravity = -9.81f;
    Vector3 velocity;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move * speed * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.Space) && Mathf.Abs(rb.velocity.y) < 0.01f)
        { // condition for get value a buttons for method jump and added velocity into y 
            rb.AddForce(Vector3.up * jump, ForceMode.Impulse);

            Debug.Log("Jump!");
        }
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
       

    }
  
    public void Jump()
    { //Jump is called that method for jump
        try
        {
            if (Input.GetKeyDown(KeyCode.Space) && Mathf.Abs(rb.velocity.y) < 0.01f)
            { // condition for get value a buttons for method jump and added velocity into y 
                rb.AddForce(Vector3.up * jump, ForceMode.Impulse);
                
                Debug.Log("Jump!");
            }
        }
        catch (Exception ex)
        {
            Debug.Log(ex + "Error!"); // checking if we have a problems 
        }

    }

}
