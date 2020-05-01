using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointControl : MonoBehaviour
{
    private GameControl game;
    // Start is called before the first frame update
    void Start()
    {
        game = GameObject.FindWithTag("GameController").GetComponent<GameControl>();        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Gate Passed");
        game.GateActivated(this);
    }
}
