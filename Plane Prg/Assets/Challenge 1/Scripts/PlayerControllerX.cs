using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public float verticalInput;
    public float horoInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");
        //horoInput = Input.GetAxis("Horizontal");

        // move the plane forward at constant speed
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        // tilt the plane up/down based on w and s
        transform.Rotate(Vector3.right * verticalInput * rotationSpeed * Time.deltaTime);
        
        // give the plane some roll
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.back *Time.deltaTime * rotationSpeed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.forward *Time.deltaTime * rotationSpeed);
        }
        
        //several plane controls were made and commented out.
    }
}
