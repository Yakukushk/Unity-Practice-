using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(MeshFilter))] // attribute for active component and checking that mesh filter on the same object as the script
public class NewMesh : MonoBehaviour
{
    // Use this for initialization
    public void Start()
    {
        gameObject.AddComponent<MeshFilter>();
        gameObject.AddComponent<MeshRenderer>();
        Mesh mesh = GetComponent<MeshFilter>().mesh; // use getcomponent to get meshfilter
        CreateMesh();
    }

    public void CreateMesh() { //void for sharing with data vertices u triangles 
        try
        {
            Mesh mesh = new Mesh();
            mesh.Clear();
            mesh.vertices = new Vector3[]
            {
                new Vector3(0,0,0),
                new Vector3(0,1,0),
                new Vector3(1,1,0)

            };
            mesh.uv = new Vector2[] {
            new Vector2(0,0),
            new Vector2(0,1),
            new Vector2(1,1)
            };
            mesh.triangles = new int[] {
            0,1,2
            };
        }
        catch (Exception ex) {
            Debug.Log(ex);
        }
    }
}
