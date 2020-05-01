using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SteeringControl : MonoBehaviour
{
    public Transform ship; 
    private float turnSpeed = 0.05f; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //float y = transform.position.y;
        
        //float distance = 5.0f;
        //transform.position = (transform.position - ship.transform.position).normalized * distance + ship.transform.position;
        //float turnInput = Input.GetAxis ("Horizontal");
        //transform.position += -transform.right * turnInput * turnSpeed; //new Vector3(transform.position.x+(turnInput*turnSpeed),transform.position.y,transform.position.z);

        //transform.position = new Vector3(transform.position.x, y, transform.position.z);
        //transform.LookAt(ship);
    }
}
