using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    float acceleration = 0f;
    float speed = 0f;
    float bofa = 2.4f;

    public float accelerationIncrement;
    public float movementForce;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            //Move forward here
            Rigidbody r = gameObject.GetComponent<Rigidbody>();
            r.AddForce(new Vector3(0f, 0f, movementForce * Time.deltaTime));
        }
        if(Input.GetKey(KeyCode.S))
        {
            //Move forward here
            Rigidbody r = gameObject.GetComponent<Rigidbody>();
            r.AddForce(new Vector3(0f, 0f, - movementForce * Time.deltaTime));
        }
        if(Input.GetKey(KeyCode.A))
        {
            //Move forward here
            Rigidbody r = gameObject.GetComponent<Rigidbody>();
            r.AddForce(new Vector3(-movementForce * Time.deltaTime, 0f, 0f));
        }
        if(Input.GetKey(KeyCode.D))
        {
            //Move forward here
            Rigidbody r = gameObject.GetComponent<Rigidbody>();
            r.AddForce(new Vector3(movementForce * Time.deltaTime, 0f, 0f));
        }
    }
}
