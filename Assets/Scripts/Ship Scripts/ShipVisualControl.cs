using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipVisualControl : MonoBehaviour
{
    public Transform target, steeringBall;
    private float turnSpeed = 0.05f; 

    void FixedUpdate()
    {
        transform.position = new Vector3(target.position.x, target.position.y+1f, target.position.z);
        float turnInput = Input.GetAxis ("Horizontal");
        transform.Rotate(Vector3.up * turnInput);
    }
}
