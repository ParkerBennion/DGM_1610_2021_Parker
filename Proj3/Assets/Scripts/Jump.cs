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
    public ParticleSystem pof,dirt;
    public AudioClip jumpSound, crashSound;
    public AudioSource PlayerAudio;
    void Start()
    {
        FoxRb = GetComponent<Rigidbody>();
        playerAnim = GetComponent<Animator>();
        PlayerAudio = GetComponent<AudioSource>();
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
            dirt.Stop();
            PlayerAudio.PlayOneShot(jumpSound,1.0f);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            jumpAvailable = true;
            dirt.Play();
        }
        else if (other.gameObject.CompareTag("obstacle"))
        {
            gameOver = true;
            Debug.Log("game over");
            playerAnim.SetBool("Death_b",true);
            playerAnim.SetInteger("DeathType_int",2);
            pof.Play();
            dirt.Stop();
            PlayerAudio.PlayOneShot(crashSound,1.0f);
        }
    }
}
