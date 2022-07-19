using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float health = 5;
    float amount;
    public float life = 3;
     void Awake()
    {
        Destroy(gameObject, life);    
    }
    public void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        Destroy(gameObject);
    }
}
