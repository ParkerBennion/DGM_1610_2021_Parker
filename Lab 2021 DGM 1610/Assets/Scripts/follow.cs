using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow : MonoBehaviour
{
    public Vector3 mosePosxy;
    public float xBound, yBound, zBound;

    // Update is called once per frame
    void Update()
    {
        //mosePosxy = Camera.main.ScreenToWorldPoint(mosePosxy);
        mosePosxy.x = Input.mousePosition.x;
        mosePosxy.y = Input.mousePosition.y;
        mosePosxy.z = -4;
        mosePosxy = Camera.main.ScreenToWorldPoint(mosePosxy);
        transform.Translate(mosePosxy);
        if (transform.position.x < -xBound)
        {
            transform.position = new Vector3(-xBound, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xBound)
        {
            transform.position = new Vector3(xBound, transform.position.y, transform.position.z);
        }
        
        if (transform.position.y < -yBound)
        {
            transform.position = new Vector3(-yBound, transform.position.x, transform.position.z);
        }
        if (transform.position.y > yBound)
        {
            transform.position = new Vector3(yBound, transform.position.x, transform.position.z);
        }
        
        if (transform.position.z < -zBound)
        {
            transform.position = new Vector3(-zBound, transform.position.y, transform.position.x);
        }
        if (transform.position.z > zBound)
        {
            transform.position = new Vector3(zBound, transform.position.y, transform.position.x);
        }
        //^^ attempt to limit bouds to see what was happeneing as the object is flying really fast.
        
    }
}
