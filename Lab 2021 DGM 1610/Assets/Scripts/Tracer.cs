using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tracer : MonoBehaviour
{
    private float power = 50;
    private Vector3 bulletPos;
    public GameObject TracerMark;
    public GameObject whereItIs;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * power * Time.deltaTime);
        //bulletPos = transform.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SilkScreen"))
        {
            //Debug.Log(bulletPos);
            Instantiate(TracerMark, whereItIs.transform.position, transform.rotation);
            Destroy(gameObject);
            
        }
    }
}
