using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Expire : MonoBehaviour
{
    private float leftLimit = 15;
    //private float rightLimit = 15;
    //private float topLimit = 15;
    private float botLimit = 15;
    //private float froLimit = 15;
    private float depthLimit = 15;
    void Update()
    {
        if (transform.position.x < -leftLimit || transform.position.x > leftLimit ||
            transform.position.y < -botLimit || transform.position.y > botLimit ||
            transform.position.z < -depthLimit || transform.position.z > depthLimit)
        {
            Destroy(gameObject);
        } 
    }
    //master kill box
}
