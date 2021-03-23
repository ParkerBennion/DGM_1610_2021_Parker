using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 reticle = Input.mousePosition;
        reticle.z = 11f;
        this.transform.position = Camera.main.ScreenToWorldPoint(reticle);
    }
}
