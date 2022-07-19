using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public Transform spawnpoint;
    public GameObject pointgameObject;
    public float damage = 10f;
    public float range = 10f;
    public float speed = 10;
    
    Bullet bullets;
    public Camera fpsCamera;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            SimpleShoot();
            Debug.Log(str());
            Debug.DrawLine(this.transform.position, Vector3.zero);
        }
    }
    void Shooting() {
        RaycastHit raycastHit;
        if (Physics.Raycast(fpsCamera.transform.position, fpsCamera.transform.forward, out raycastHit, range)) {
            Debug.Log(raycastHit.transform.name);
            traget target = raycastHit.transform.GetComponent<traget>();
            if (target != null) {
                //target.TakeDamege(damage);
            }
        }
    }
    void SimpleShoot() {
        RaycastHit raycastHit_;
       
        var bullet = Instantiate(pointgameObject, spawnpoint.position, spawnpoint.rotation);
            bullet.GetComponent<Rigidbody>().velocity = spawnpoint.forward * speed;

       }
    string str() => "Working";
}
