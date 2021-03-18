using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    private Rigidbody FoxRb;
    private Animator playerAnim;
    public float jumpforce;
    public float gravForce;
    public bool jumpAvailable;
    public bool gameOver;
    void Start()
    {
        FoxRb = GetComponent<Rigidbody>();
        playerAnim = GetComponent<Animator>();
        Physics.gravity *= gravForce;
        jumpAvailable = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && jumpAvailable && gameOver != true)// or !gameOver
        {
            FoxRb.AddForce(Vector3.up * jumpforce, ForceMode.Impulse);
            jumpAvailable = false;
            playerAnim.SetTrigger("Jump_trig");
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
            playerAnim.SetBool("Death_b",true);
            playerAnim.SetInteger("DeathType_int",2);
        }
    }
}
