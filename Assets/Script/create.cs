using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class create : MonoBehaviour
{

    public float x;
    public float y;
    public GameObject cube;
    public GameObject cubeng;
    // Use this for initialization
    void Start()
    {
        wally();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            for (int i = 0; i < x; i++)
            {
                Quaternion spawnRotation = Quaternion.identity;
                for (int j = 1; j < y; j++)
                {
                    Instantiate(cubeng, new Vector3(i, j,2), spawnRotation);
                }
            }
        }
        if (Input.GetKey(KeyCode.B))
        {
            for (int i = 0; i < x; i++)
            {
                Quaternion spawnRotation = Quaternion.identity;
                for (int j = 1; j < y; j++)
                {
                    Instantiate(cubeng, new Vector3(i, j, 10), spawnRotation);
                }
            }
        }
        if (Input.GetKey(KeyCode.C))
        {
            for (int i = 0; i < x; i++)
            { 
                Quaternion spawnRotation = Quaternion.identity;
                for (int j = 1; j < y; j++)
                {
                    Instantiate(cubeng, new Vector3(i, 10,j+1), spawnRotation);
                }
            }
        }
        if(Input.GetKey((KeyCode.K))){
            wally();
        }
    }

    void wally(){
        for (int i = 0; i < x; i++)
        {
            Quaternion spawnRotation = Quaternion.identity;
            for (int j = 1; j < y; j++)
            {
                Instantiate(cube, new Vector3(i, j), spawnRotation);
            }
        }
    }
}
