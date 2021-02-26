using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 20f, horoInput, xRange;
    public GameObject projectileFab;
    public Vector3 player;

    void Update()
    {
        horoInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horoInput* Time.deltaTime * speed);
        //gives movement

        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        //restricts leteral movement

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectileFab, transform.position, projectileFab.transform.rotation);
        }
        
    }
}
