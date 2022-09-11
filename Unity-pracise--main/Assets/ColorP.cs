using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorP : MonoBehaviour
{
    public GameObject[] game = new GameObject[2];
    private float rightMove = 5f;
    // Start is called before the first frame update
    void Start()
    {
        string[] strings = new string[3];
        int[] num = {1,2,3,4 };
        int numEnemies = 3;
        int count = 4;
        int num1 = 2;

        strings[0] = "First";
        strings[1] = "Second";
        strings[2] = "Third";

        foreach (var item in strings) {
            print(item);
        }
        foreach (var item1 in num) {
            Debug.Log(item1);
        }
        for (var i = 0; i < numEnemies; i++) {
            Debug.Log($"Count {num1}" + i);
        }
        while (count > 0) {
            Debug.Log("OK");
            count--;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            game[0].GetComponent<Renderer>().material.color = Color.black;
            game[1].GetComponent<Renderer>().material.color = Color.yellow;
        }
        else {
            game[0].GetComponent<Renderer>().material.color = Color.white;
            game[1].GetComponent<Renderer>().material.color = Color.green;
        }
        if (Input.GetKey(KeyCode.D))
        {
            game[0].transform.Translate(Vector3.forward * 5f * Time.deltaTime);
        }


    }


}
