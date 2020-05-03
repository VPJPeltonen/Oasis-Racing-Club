using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIBallControl : BallControl
{
    void FixedUpdate()
    {
        if(!active){return;}
        float moveVertical = 1f;
        MoveShip(moveVertical);
    }
}
