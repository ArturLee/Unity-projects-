using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour {


    public float speed;
    public float speedTurn;
    private Rigidbody rb;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }
    void Update()
    {
       
        if (Input.GetKey(KeyCode.UpArrow)){
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.back * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(Vector3.up * 5f * Time.deltaTime);
        }
        //rotation parte
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(Vector3.up, speedTurn * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Rotate(Vector3.down, speedTurn * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(Vector3.left, speedTurn * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.R))
        {
            transform.Rotate(Vector3.right, speedTurn * Time.deltaTime);
        }
        if(Input.GetKeyDown(KeyCode.B)){
            GetComponent<Renderer>().material.color = Color.blue;
        }

        //Change color
        if (Input.GetKeyDown(KeyCode.G))
        {
            GetComponent<Renderer>().material.color = Color.green;
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            GetComponent<Renderer>().material.color = Color.red;
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            GetComponent<Renderer>().material.color = Color.grey;
        }

        //Desaparecer
        if(Input.GetKey(KeyCode.D))
        {
            GetComponent<Renderer>().enabled = false;
        }
        if (Input.GetKey(KeyCode.A))
        {
            GetComponent<Renderer>().enabled = true;
        }
        if (Input.GetKey(KeyCode.K))
        {
            Destroy(gameObject);
        }
    }
    private void OnMouseDown()
    {
        Destroy(gameObject);
    }
}
