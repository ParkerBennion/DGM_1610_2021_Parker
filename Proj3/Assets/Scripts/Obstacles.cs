using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{
    public float speed = 5;
    private Jump jumpScript;

    private void Start()
    {
        jumpScript = GameObject.Find("player").GetComponent<Jump>();
    }

    void Update()
    {
        transform.Translate(Vector3.left*Time.deltaTime*speed);

        if (jumpScript.gameOver == true)
        {
            speed = 0;
        }
    }
}
