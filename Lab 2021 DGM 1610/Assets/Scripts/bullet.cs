using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    private float power = 7;
    // Start is called before the first frame update
    void Update()
    {
        transform.Translate(Vector3.forward * power * Time.deltaTime);
    }
}
