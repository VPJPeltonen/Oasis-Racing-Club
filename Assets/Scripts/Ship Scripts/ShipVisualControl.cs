using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipVisualControl : MonoBehaviour
{
    public Transform target, steeringBall;
    protected float turnSpeed = 3f; 
    protected bool active = false;

    public bool Active { get => active; set => active = value; }

    void FixedUpdate()
    {
        if(!active){return;}
        float turnInput = Input.GetAxis ("Horizontal");
        transform.Rotate(Vector3.up * turnInput * turnSpeed);
        MaintainPosition();
    }

    protected void MaintainPosition(){
        transform.position = new Vector3(target.position.x, target.position.y+1f, target.position.z);
    }
}
