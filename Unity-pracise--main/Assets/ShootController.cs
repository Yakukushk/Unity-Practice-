using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootController : MonoBehaviour
{
    [SerializeField] private bool IsShooting_ = false;
    [SerializeField] private float VelocityBullet_ = 15f;
    [SerializeField] private GameObject BulletObject = null;

    private void Update()
    {
        Shooting();
    }
    void Shooting() {
        if (IsShooting_)
        {
            int i = 0;
            Debug.LogError(i++);
        }
        else {
            if (Input.GetKeyDown(KeyCode.Space)) {
                GameObject newBullet = Instantiate(BulletObject, transform.position, transform.rotation);
                newBullet.GetComponent<Rigidbody>().velocity = transform.forward * VelocityBullet_;
            }
        }
    }
   
}
