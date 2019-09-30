using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class create2 : MonoBehaviour {
    public float gridx;
    public float gridy;
    public GameObject cube;
    public Rigidbody cubes;
    public float space;
    public float radios;
    public float speed;

	// Use this for initialization
	void Start () {
        for (int i = 0; i < gridx; i++)
        {
            float angle = i * Mathf.PI * 2 / gridx;
            float x = Mathf.Sin(angle);
            float y = Mathf.Cos(angle);
            Instantiate(cube, new Vector3(x, y, 0) * radios, Quaternion.identity);
        }
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.G))
        {
            for (int i = 0; i < gridx; i++)
            {
                for (int j = 0; j < gridy; j++)
                {
                    Vector3 Pos = new Vector3(i, 3, j) * space;
                    Instantiate(cube, Pos, Quaternion.identity);
                }
            }
        }
        if (Input.GetKey(KeyCode.C))
        {
            for (int i = 0; i < gridx; i++)
            {
                float angle = i * Mathf.PI * 2 / gridx;
                float x = Mathf.Sin(angle);
                float y = Mathf.Cos(angle);
                Instantiate(cube,new Vector3(y,3,x)*radios,Quaternion.identity);
            }
        }
        if (Input.GetButtonDown("Fire1"))
            firebullet();
	}

    void firebullet(){
//        Rigidbody bullet = (Rigidbody)Instantiate(cubes, transform.position, transform.rotation) as Transform;
   //     bullet.velocity = transform.up * speed;
    }
}
