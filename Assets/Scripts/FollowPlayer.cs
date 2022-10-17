using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;

    public bool pvInput;

    private bool cameraPos = true;

    private Vector3 offset = new Vector3(0, 5, -9);
    private Vector3 firstPersonPosition = new Vector3(0, 2, 1);

    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate() 
    {
        float desiredAngle = player.transform.eulerAngles.y;
        Quaternion rotation = Quaternion.Euler(0, desiredAngle, 0);
        
        if (cameraPos == true) {
            transform.position = player.transform.position + (rotation * firstPersonPosition);
            transform.rotation = player.transform.rotation;
        }
        else {
            transform.position = player.transform.position + (rotation * offset);
            transform.LookAt(player.transform.position);
        }
    }
    void Update()
    {
        pvInput = Input.GetButtonDown("Jump");

        if (pvInput) {
            cameraPos = !cameraPos;
        }
    }
}
