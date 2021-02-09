using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyScript : MonoBehaviour
{
    private float topSide = 35;
    private float botSide = -15;
    /*void Start()
    {
        //Destroy(gameObject, 3);
        // timer to destroy game object after 3 seconds of creation
    }*/

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topSide)
        {
            Destroy(gameObject); 
        } 
        else if (transform.position.z < botSide)
        {
            Debug.Log("GAME OVER");
            Destroy(gameObject);
        } 
    }
}
