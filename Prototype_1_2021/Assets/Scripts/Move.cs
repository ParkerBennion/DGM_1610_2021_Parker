using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float forwardButton, sideButton, speed, turnSpeed;

        void Start()
        {
            turnSpeed = 40;
        }
    
        void Update()
    {
        forwardButton = Input.GetAxis("Vertical");
        sideButton = Input.GetAxis("Horizontal");
        
        transform.Rotate(Vector3.up,Time.deltaTime * sideButton * turnSpeed);
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardButton);
        /*if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime* speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Time.deltaTime* speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * Time.deltaTime* speed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime* speed);
        }*/
        
        //transform.Translate(Vector3.right * Time.deltaTime * speed * sideButton);
        
        //^^^ these are other methods of moving the car.
        
    }
}
