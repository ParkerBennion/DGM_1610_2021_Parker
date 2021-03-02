using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    private Rigidbody FoxRb;
    public float jumpforce;
    public float gravForce;
    public bool jumpAvailable;
    public bool gameOver;
    void Start()
    {
        FoxRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravForce;
        jumpAvailable = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && jumpAvailable)
        {
            FoxRb.AddForce(Vector3.up * jumpforce, ForceMode.Impulse);
            jumpAvailable = false;
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            jumpAvailable = true;
        }
        else if (other.gameObject.CompareTag("obstacle"))
        {
            gameOver = true;
            Debug.Log("game over");
        }
    }
}
