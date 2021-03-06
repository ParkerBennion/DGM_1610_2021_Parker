﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float gravForce, jumpForce, speed, xBound, dJump;
    public bool jumpAvailable;
    public bool doubleJump;
    private Rigidbody playerRB;
    public static Vector3 playerPositoin;

    void Start()
    { 
        playerRB = GetComponent<Rigidbody>();
        Physics.gravity *= gravForce;
        jumpAvailable = true;
        doubleJump = false;
    }
    
    void Update()
    {
        playerPositoin = transform.position;
        //forwardButton = Input.GetAxis("Vertical");
        //sideButton = Input.GetAxis("Horizontal");
        
        //transform.Rotate(Vector3.up,Time.deltaTime * sideButton * turnSpeed);
       // transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardButton);
        /*if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime* speed);
        }*/
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Time.deltaTime* speed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime* speed);
        }
        
        
        if (transform.position.x < -xBound)
        {
            transform.position = new Vector3(-xBound, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xBound)
        {
            transform.position = new Vector3(xBound, transform.position.y, transform.position.z);
        }
        
        
        if (Input.GetKeyDown(KeyCode.Space) && jumpAvailable)
        {
            playerRB.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            jumpAvailable = false;
            doubleJump = true;
        }

        if (Input.GetKeyDown(KeyCode.W) && !jumpAvailable && doubleJump)
        {
            playerRB.velocity = transform.up * Time.deltaTime* dJump;
            doubleJump = false;
        }
        //lets do a double jump >> reference the dog fetch timer script maybe
        

    }
    private void OnCollisionEnter(Collision other)
    {
        jumpAvailable = true;
        doubleJump = false;
    }
}