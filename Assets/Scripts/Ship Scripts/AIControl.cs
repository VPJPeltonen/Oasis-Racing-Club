using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIControl : MonoBehaviour
{
    public AIBallControl ball;
    public AIVisualControl ship; 
    // Start is called before the first frame update

    public void SetActiveStatus(bool status){
        ball.Active = status;
        ship.Active = status;
    }
}
