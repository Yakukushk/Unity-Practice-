using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FisrtCamera : MonoBehaviour
{
    // Start is called before the first frame update
    public float mouseSentetive = 100f;
    public Transform playerbody;
    float RoationX = 0f;
    Rigidbody rb;
    public float speed;
    
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSentetive * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSentetive * Time.deltaTime;
        RoationX -= mouseY;
        RoationX = Mathf.Clamp(RoationX, -90f, 90f);
        transform.localRotation = Quaternion.Euler(RoationX, 0f, 0f);
        playerbody.Rotate(Vector3.up * mouseX);
    }
    private void FixedUpdate()
    {
       
    }
   
}
