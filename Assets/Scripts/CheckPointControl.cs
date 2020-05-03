using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointControl : MonoBehaviour
{
    private GameControl game;

    void Start()
    {
        game = GameObject.FindWithTag("GameController").GetComponent<GameControl>();        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Gate Passed");
        if(other.gameObject.tag == "Player"){
            game.GateActivated(this);
        }
        
    }
}
