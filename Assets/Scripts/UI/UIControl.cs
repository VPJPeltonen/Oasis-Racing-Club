using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIControl : MonoBehaviour
{
    public TextMeshProUGUI countdownText,totalTimerText,finalText;

    public void ShowTimes(string passedTime, string leftTime){
        totalTimerText.text = passedTime;
        countdownText.text = leftTime;
    }

    public void GameOver(){
        finalText.gameObject.SetActive(true);
        totalTimerText.gameObject.SetActive(true);
        countdownText.gameObject.SetActive(true);
    }
}
