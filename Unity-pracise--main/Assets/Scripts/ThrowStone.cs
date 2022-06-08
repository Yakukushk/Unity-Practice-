using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowStone : MonoBehaviour
{
    public GameObject[] gameObjects = new GameObject[3];
    public float tounge = 5.0f;
    public float maxGravity = 20.0f, minGravity = 40.0f;
    public float maxForce = 15.0f, minForce = -15.0f;
    public float minTime = 0.5f, maxTime = 1.5f;
    public float minZ = -30.0f, maxX = 30.0f;
    public float minX = -5.0f, maxZ = 20.0f;
    private float TimeStart = 2.0f;
    private float Ydie = -30.0f;
    private bool enableStones = true;
    private Rigidbody rb;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StonesThrow());
       // Delete();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator StonesThrow() {
        yield return new WaitForSeconds(TimeStart * Time.deltaTime);
        while (enableStones)
        {
            GameObject stone = (GameObject)Instantiate(gameObjects[Random.Range(0, gameObjects.Length)]);
            stone.transform.position = new Vector3(Random.Range(minX, maxX), -30f, Random.Range(minZ, maxX));
            stone.transform.rotation = Random.rotation;
            rb = stone.GetComponent<Rigidbody>();
            rb.AddTorque(Vector3.up * tounge, ForceMode.Impulse);
            rb.AddTorque(Vector3.right * tounge, ForceMode.Impulse);
            rb.AddTorque(Vector3.forward * tounge, ForceMode.Impulse);

            rb.AddForce(Vector3.up * Random.Range(minGravity, maxGravity), ForceMode.Impulse);
            rb.AddForce(Vector3.right * Random.Range(minForce, maxForce), ForceMode.Impulse);

            yield return new WaitForSeconds(Random.Range(minTime, maxTime));
            GameManager.countThrows++;

        }
    }
    void Delete() {
        if (transform.position.y > Ydie) {
            Destroy(gameObjects[3]);
        }
    }
}
