using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 10.0f;
    public float turnSpeed = 1;

    public float rotateSpeed = 50;
    public float horizonalInput;
    public float verticalInput;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // this is where we get the player input from the keyboad button presses
        horizonalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        // moving the vehicle forward and turn the vehicle
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        transform.Rotate(Vector3.up, Time.deltaTime * rotateSpeed * horizonalInput);
    }
}
