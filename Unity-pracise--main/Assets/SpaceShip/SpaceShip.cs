using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShip : MonoBehaviour
{
    private Rigidbody _rigidbody;
    public float speed = 5f;
    public float speedRotation = 1f;
    public GameObject bulletObject = null;
    public GameObject[] weapons = null;
    public float BulletVelocity = 15f;
    private bool IsShooting = false;
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _rigidbody.maxAngularVelocity = Mathf.Infinity;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        MoveSpaceShip();
    }
     void Update()
    {
      //  ShootingSpaceShip();
    }
    public void MoveSpaceShip() {
        float Y = Input.GetAxis("Horizontal") * speedRotation;
        float Z = Input.GetAxis("Vertical") * speed;

        _rigidbody.AddRelativeForce(0f, 0f, Z);
        _rigidbody.AddRelativeTorque(0f, Y, 0f);
    }
    public void ShootingSpaceShip()
    {
        if (IsShooting)
        {
            string txt = "Not Shooting";
            Debug.Log(txt);
        }
        else {
            if (Input.GetKeyDown(KeyCode.Space)) {
                for (var i = 0; i < weapons.Length; i++) {
                    weapons[i] = Instantiate(bulletObject, transform.position, transform.rotation);
                    weapons[i].GetComponent<Rigidbody>().velocity = transform.forward * BulletVelocity;
                }
            }
        }

    }
}
