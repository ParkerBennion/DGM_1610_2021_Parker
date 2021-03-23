using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Aiming : MonoBehaviour
{
    //public Transform reticle;

    //public Vector3 orient;
    void Update()
    {
        aim();
        
        
        
        
        //orient.x =Input.GetAxis("Mouse X") * Time.deltaTime; //every frome the x cordnate on positoin will equal that of the mouse.
        //orient.y =Input.GetAxis("Mouse Y") * Time.deltaTime;
        
        //reticle.Rotate(Vector3.up * orient.x);
    }
    
    //^ this didnt work. i appears to be more for a fps type world as it get a mouse rotation.
    // https://www.youtube.com/watch?v=_XdqA3xbP2A this tutorial is wehre im going to continue to find solution to scrips.
    void aim()
    {
        Vector3 ready = Input.mousePosition;
        ready = Camera.main.ScreenToWorldPoint(ready);

         Vector3 direction = new Vector3(
             ready.x - transform.position.x,
             ready.y - transform.position.y,
             ready.z = 8.3f);
         transform.forward = direction;

    }
    

}
