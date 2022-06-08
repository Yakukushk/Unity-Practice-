using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destory : MonoBehaviour
{
    public GameObject part;
    private float Ydie = -30.0f;
    // Start is called before the first frame update
    void Start()
    {
        Delete();
    }

    void Delete() {
        if (transform.position.y < Ydie) {
            Destroy(gameObject);
        }

    }

    private void OnMouseDown()
    {
        Destroy(Instantiate(part, transform.position, Quaternion.identity), 2.0f);
        Destroy(gameObject);
        GameManager.countDestroy++;
    }
}
