using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tuto : MonoBehaviour
{

    public GameObject cubeObj;
    public Color color;

    // Start is called before the first frame update
    void Start()
    {
        for(int i=0; i<10; i++)
            for (int j = 0; j < 10; j++)
            {
                GameObject go = Instantiate(cubeObj, new Vector3(i, 0, j), Quaternion.identity);
                if (j % 2 == 0 && i % 2 == 0) {

                    go.GetComponent<MeshRenderer>().material.color = color;
                    go.transform.position += Vector3.up;
                }
                
            }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
