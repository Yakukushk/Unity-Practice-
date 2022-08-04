using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    float HotCofee = 85f;
    float HotCoffeeLimit = 70f;
    float ColdCoffee = 40f;
    int EnemiesCount = 3;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(gameObject.transform.position.x);

        if (gameObject.transform.position.x <= 5 || gameObject.transform.position.y <= 5)
        {
            Debug.Log(txt());
        }
        else {
            Debug.Log("Not be there");
        }
        for (var j = 0; j < EnemiesCount; j++)
        {
            Debug.Log("Count => {i}" + j);
        }
        bool shouldContinue = false;

        do
        {
            print("Hello World");

        } while (shouldContinue == true);

    }

    // Update is called once per frame
    void Update()
    {
        ChangeColors();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Coffeteria();
            HotCofee -= 5f * Time.deltaTime;
        }
    }
    private void Awake()
    {
        print();
        Loops();
    }
    void ChangeColors() {
        if (Input.GetKeyDown(KeyCode.Alpha0)) {
            GetComponent<Renderer>().material.color = Color.black;
        }
        if (Input.GetKeyDown(KeyCode.Alpha1)) {
            GetComponent<Renderer>().material.color = Color.grey;
            
        }
        if (Input.GetKeyDown(KeyCode.Alpha2)) {
            GetComponent<Renderer>().material.color = Color.red;
        }
    }
    void Coffeteria() {
        if (HotCofee > HotCoffeeLimit) {
            Debug.Log("Very hot!"); 
        }
        if (ColdCoffee > HotCofee)
        {
            Debug.Log("too cold");
        }
        else {
            string txt = "That's right";
            Debug.Log(txt);
        }
    }
    int function(int i = 2) => i * 2;
    string txt() => "In Ground";
    void print() {
        Debug.Log($"function i = {function()}");
    }
    void Loops() {
        int[] i = {2 , 4 , 5, 6, 1 };
        int EnemiesCount = 3;
        foreach (var item in i) {

            Debug.Log($"count items equal {item}");
        }
       
    }
}
