using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Impulse : MonoBehaviour
{
    public GameObject stone;
    public float Rangex = 1.5f;
    private float next = 0.0f;
    private bool i = true;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(enumerator());
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    IEnumerator enumerator() {
        new WaitForSeconds(2.0f);
        while (i)
        {
            Instantiate(stone, transform.position, Random.rotation);
            yield return new WaitForSeconds(Rangex);
        }
        }
}
