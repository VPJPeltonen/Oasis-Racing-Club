using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    public Transform target;
    protected bool dashInput;
    public float speed = 5.0f;
    protected bool active = false;

    public bool Active { get => active; set => active = value; }

    void FixedUpdate()
    {
        if(!active){return;}
        float moveVertical = Input.GetAxis ("Vertical");
        MoveShip(moveVertical);
    }

    protected void MoveShip(float movePower){
        Vector3 targetDir = target.position - transform.position;
        Rigidbody body = gameObject.GetComponent<Rigidbody>();
        body.AddForce (movePower * speed * targetDir);
    }
}
