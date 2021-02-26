using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aiming : MonoBehaviour
{
    public Transform reticle;

    public Vector3 orient;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        orient.x =Input.GetAxis("Mouse X") * Time.deltaTime; //every frome the x cordnate on positoin will equal that of the mouse.
        orient.y =Input.GetAxis("Mouse Y") * Time.deltaTime;
        
        reticle.Rotate(Vector3.up * orient.x);
    }
    //^ this didnt work. i appears to be more for a fps type world as it get a mouse rotation.
    // https://www.youtube.com/watch?v=_XdqA3xbP2A this tutorial is wehre im going to continue to find solution to scrips.
}
