using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipVisualControl : MonoBehaviour
{
    public Transform target, steeringBall;
    private float turnSpeed = 0.05f; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //transform.LookAt(steeringBall);
        transform.position = new Vector3(target.position.x, target.position.y+1f, target.position.z);

        float turnInput = Input.GetAxis ("Horizontal");
        //transform.position += -transform.right * turnInput * turnSpeed;
        transform.Rotate(Vector3.up * turnInput);
        //body.AddRelativeTorque(0f, turnInput * turnSpeed,0f);
        //transform.rotation = target.rotation;
       //transform.eulerAngles = new Vector3(transform.eulerAngles.x, target.eulerAngles.y, transform.eulerAngles.z);
    }
}
