﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{

    public Transform target;

    void Update()
    {
        transform.position = new Vector3(target.position.x, transform.position.y, target.position.z - 5f);
    }
}
