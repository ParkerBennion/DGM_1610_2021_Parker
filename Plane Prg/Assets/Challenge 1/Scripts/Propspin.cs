using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Propspin : MonoBehaviour
{
    public float propSpeed;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.back * propSpeed * Time.deltaTime);
    }
}
