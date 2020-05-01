using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    public Transform target;
    private bool dashInput;
    private float speed = 4.0f;
    private float turnSpeed = 5f;
    private float xDir,yDir;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 targetDir = target.position - transform.position;
        //get_input();
        Rigidbody body = gameObject.GetComponent<Rigidbody>();
        float turnInput = Input.GetAxis ("Horizontal");
        float moveVertical = Input.GetAxis ("Vertical");

        Vector3 movement = new Vector3 (0.0f, 0.0f, moveVertical);

        body.AddForce (moveVertical * speed * targetDir);
        //body.AddRelativeTorque(0f, turnInput * turnSpeed,0f);// -(turnInput * tiltSpeed));
    }

    private void get_input(){
        float xDir = Input.GetAxis("Horizontal");
        float yDir = Input.GetAxis("Vertical");
        if(Input.GetKeyDown(KeyCode.LeftShift)){
            dashInput = true;
        }
        if(Input.GetKeyUp(KeyCode.LeftShift)){
            dashInput = false;
        }
    }

}
