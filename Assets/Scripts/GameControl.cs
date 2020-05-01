using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using TMPro;

public class GameControl : MonoBehaviour
{
    public CheckPointControl[] checkPoints;
    public UIControl UI;
    public BallControl playerBall;
    public ShipVisualControl playerShip;
    private int nextGate;
    private float startTime, countdownTime, currentTimeLimit;
    private bool active = true;

    public bool Active { get => active; set => active = value; }

    void Start()
    {
        nextGate = 0;
        startTime = Time.time;
        countdownTime = Time.time;
        currentTimeLimit = 10f;
    }

    void Update()
    {
        if(!active){return;}
        float timePassed = Time.time - startTime;
        string passedTime = getTime(timePassed);
        float timeLeft = currentTimeLimit - (Time.time - countdownTime);
        string leftTime = "0:00:00";
        if(timeLeft >= 0f){
            leftTime = getTime(timeLeft);
        }else{
            GameOver();
        }
        UI.ShowTimes(passedTime,leftTime);
    }

    public void GateActivated(CheckPointControl gate){
        if(gate == checkPoints[nextGate]){
            countdownTime = Time.time;
            currentTimeLimit = 10f;
            Debug.Log("correct gate");
            if (nextGate < checkPoints.Length-1){
                nextGate += 1;
            }else{
                nextGate = 0;
            }            
        }else{
            Debug.Log("wrong gate");
        }
    }

    private string getTime(float selectedTime){
        string minutes = ((int) selectedTime/60).ToString();
        float secondsFloat = (float)selectedTime % 60;
        string seconds = secondsFloat.ToString("f2");
        if (secondsFloat <= 9.9f){
            seconds = "0" + secondsFloat.ToString("f2");
        }
        string timerTime = minutes + ":" + seconds;  
        return timerTime;
    }

    private void GameOver(){
        active = false;
        playerShip.Active = false;
        playerBall.Active = false;
        UI.GameOver();
    }
}