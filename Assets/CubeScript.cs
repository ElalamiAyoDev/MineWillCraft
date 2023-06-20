using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{
    public Color baseColor;
    public Color overColor;
    private Material mat;
    public GameObject cube;
    GameObject selectedCube; 

    private void Start()
    {
        mat = GetComponent<MeshRenderer>().material;
        baseColor = mat.color;
    }
    private void OnMouseOver()
    {
        selectedCube = this.gameObject;
        mat.color = overColor;
    }

    private void OnMouseExit()
    {
        selectedCube = null;
        mat.color = baseColor;
    }

    private void OnMouseUp()
    {
        Vector3 pos = this.transform.position + Vector3.up;
        GameObject go = Instantiate(cube, pos, Quaternion.identity);
        go.AddComponent<Rigidbody>();
        go.GetComponent<MeshRenderer>().material.color = new Color(0.1f,0.1f,0.1f);
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
            Destroy(selectedCube);
   
    }
}
