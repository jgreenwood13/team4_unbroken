using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{
    public float timeLeft = 45f;
    public Text countdownText;

    void Update()
    {
        timeLeft -= Time.deltaTime;
        countdownText.text = "00:" + timeLeft.ToString("0");
        if (timeLeft < 0)
        {
            timeLeft = 0;
        }
    }
}