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
    private Mesh _mesh;
    private int[] triangles;
    private Color[] colors;
    public GameObject cube;
    public MeshRenderer MeshRenderer;
    private Material material;

    // Start is called before the first frame update
    public void Start()
    {
        rigidbody = GetComponent<Rigidbody>(); // sharing values component between rigidbody & Rigidbody's component 
        source = GetComponent<AudioSource>();// sharing values component between source & AudioSource's component  
        cube = GameObject.CreatePrimitive(PrimitiveType.Cube);

       
        var cubeRenderer = cube.GetComponent<Renderer>();
        //  _mesh = GetComponent<Mesh>();
        //  GetComponent<MeshFilter>().mesh = _mesh;
        // MeshRenderer meshRenderer = GetComponent<MeshRenderer>();


        // triangles = _mesh.triangles;
        // colors = _mesh.colors;
        // MeshRender();
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
                material.color = Color.black;
                Debug.Log("Jump!");
            }
        }
        catch (Exception ex) {
            Debug.Log(ex + "Error!"); // checking if we have a problems 
        }
       
    }
    public void OnCollisionEnter(Collision collision) // In brief, we will detect others obj in order to tag 
    {
        if (collision.gameObject.tag == "Enemy") { // condition for finding obj 
            print("Active"); 
            Destroy(collision.gameObject); // Remove obj 
        }
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player") {
            print("Active for Trigger");
            var cubeRenderer = cube.GetComponent<Renderer>();
            cubeRenderer.material.SetColor("_Color", Color.red);

        }
    }
    // public void MeshRender()
    //  {
    //  for (int i = 0; i < triangles.Length; i++) {
    //     if (i > 0)
    //    {
    //    colors[i] = Color.red;
    // }
    //  else {
    //       colors[i] = Color.white;
    //   }
    // }
    // }
}
