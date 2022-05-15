using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(MeshFilter), typeof(MeshRenderer)), ExecuteAlways] // attribute for active component and checking that mesh filter on the same object as the script
public class NewMesh : MonoBehaviour
{
    public Material material = null;

    private Vector3[] vertices = new Vector3[3];
    private int[] triangles = new int[3];
    private Color[] _colors = new Color[3];

    private void Start()
    {
        vertices[0] = new Vector3(0, 0, 0);
        vertices[1] = new Vector3(0, 1, 0);
        vertices[2] = new Vector3(1, 0, 0);

        triangles[0] = 0;
        triangles[1] = 1;
        triangles[2] = 2;

        _colors[0] = new Color(1, 0, 0);
        _colors[1] = new Color(0, 1, 0);
        _colors[2] = new Color(0, 0, 1);

        Mesh m = GetMesh();
        SetMesh(ref m);
    }
    private Mesh GetMesh()
    {
        Mesh m = null;

        if (Application.isEditor == true)
        {
            MeshFilter mf = this.GetComponent<MeshFilter>();
            if (mf == null)
            {
                mf = this.gameObject.AddComponent<MeshFilter>();
                mf.sharedMesh = new Mesh();
            }
            m = mf.sharedMesh;
        }
        else
        {
            MeshFilter mf = this.GetComponent<MeshFilter>();
            if (mf == null)
            {
                mf = this.gameObject.AddComponent<MeshFilter>();
                mf.mesh = new Mesh();
            }
            m = mf.mesh;
        }

        MeshRenderer mr = this.GetComponent<MeshRenderer>();
        if (mr == null)
            mr = this.gameObject.AddComponent<MeshRenderer>();
        mr.material = material;

        return m;
    }
    public void SetMesh(ref Mesh m)
    {
        m.Clear();

        m.vertices = vertices;
        m.triangles = triangles;
        m.colors = _colors;


        m.RecalculateBounds();
        m.RecalculateNormals();
        m.RecalculateTangents();
    }
}