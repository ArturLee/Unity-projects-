using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controll : MonoBehaviour {

    public float speed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.W)){
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(Vector3.up  * speed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.LeftShift)){
            //AddForce(0, 9, 0);
        }
        float h = speed * Input.GetAxis("Mouse X");
        //float v = speed * Input.GetAxis("Mouse Y");
        transform.Rotate(0, h, 0);
	}
}
