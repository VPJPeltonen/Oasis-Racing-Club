using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIControl : MonoBehaviour
{
    public TextMeshProUGUI countdownText,totalTimerText,finalText,gatesPassedText;
    public GameObject endView;

    public void ShowTimes(string passedTime, string leftTime){
        totalTimerText.text = passedTime;
        countdownText.text = leftTime;
    }

    public void GameOver(int amount){
        endView.SetActive(true);
        finalText.gameObject.SetActive(true);
        finalText.text = "YOUR RACING DAYS\nARE OVER\n" + "YOU PASSED " + amount.ToString() + " GATES";
        totalTimerText.gameObject.SetActive(true);
        countdownText.gameObject.SetActive(true);
    }

    public void UpdateGatesAmount(int amount){
        gatesPassedText.text = amount.ToString();
    }
}
