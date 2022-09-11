using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KarasikMove : MonoBehaviour
{
    private bool IsMove = false;
    private float speed = 15f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Move();
    }

    void Move() {
        if (IsMove)
        {
            string txt = "Aboba";
            Debug.Log(txt);
        }
        else {
            if (Input.GetKey(KeyCode.W)) {
                gameObject.transform.Translate(Vector3.forward * speed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.A))
            {
                gameObject.transform.Translate(Vector3.left * speed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.D))
            {
                gameObject.transform.Translate(Vector3.right * speed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.S))
            {
                gameObject.transform.Translate(Vector3.back * speed * Time.deltaTime);
            }
        }
    }
}
