using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(MeshFilter))] // attribute for active component and checking that mesh filter on the same object as the script
public class MeshGenerator : MonoBehaviour
{
    Vector3[] vector3s; 
    Mesh mesh;
    int[] triangles; 
    // Start is called before the first frame update
   public void Start()
    {
        mesh = GetComponent<Mesh>();
        GetComponent <MeshFilter>().mesh = mesh; // use getcomponent to get meshfilter
    }

    public void CreateMesh() {
        vector3s = new Vector3[] // create vertices 
        {
        new Vector3(0,0,0), 
        new Vector3(0,0,1),
        new Vector3(0,1,0)
        };
        triangles = new int[] { // create triangles 
        0,1,2
        };

    }
    public void MeshUpdate() // void for sharing with data vertices u triangles 
    {
        mesh.Clear(); // First of all, clearing mesh;
        mesh.vertices = vector3s;
        mesh.triangles = triangles;
    }
}
