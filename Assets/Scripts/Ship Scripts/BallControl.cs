using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    public Transform target;
    private bool dashInput;
    private float speed = 4.0f;
    private float turnSpeed = 5f;

    void FixedUpdate()
    {
        Vector3 targetDir = target.position - transform.position;
        Rigidbody body = gameObject.GetComponent<Rigidbody>();
        float moveVertical = Input.GetAxis ("Vertical");
        Vector3 movement = new Vector3 (0.0f, 0.0f, moveVertical);
        body.AddForce (moveVertical * speed * targetDir);
    }
}
