using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class timer : MonoBehaviour
{

    private float timeLeft = 600;
    private TextMeshProUGUI timeText;
    private int mins;
    private int sec;

    // Start is called before the first frame update
    void Start()
    {
        timeText = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        if(timeLeft <= 120)
        {
            timeText.color = Color.red;
        }
        if (timeLeft < 0)
        {
            timeText.text = "Time\'s up!";
        }
        else
        {
            mins = (int)timeLeft / 60;
            sec = (int)((timeLeft / 60f - mins) * 60);
            if(sec < 10)
            {

                timeText.text = mins + ":0" + sec;
            } else
            {

                timeText.text = mins + ":" + sec;
            }
        }
    }
}
