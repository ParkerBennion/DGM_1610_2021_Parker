using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    private Vector3 offset = new Vector3(0,3f,-11f);

    // Update is called once per frame
    void Update()
    {
        transform.position = plane.transform.position + offset;
        transform.rotation = plane.transform.rotation;
    }
}
