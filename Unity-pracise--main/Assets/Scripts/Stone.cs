using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stone : MonoBehaviour
{
    [SerializeField] private float force = 10.0f;
    private Rigidbody rigidbody;
    // Start is called before the first frame update
    void Start()
    {
       
       rigidbody = GetComponent<Rigidbody>();
       rigidbody.AddForce(Vector3.up * force, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -1.0f) {
            Destroy(gameObject); 
        }
    }
}
