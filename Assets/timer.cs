using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class timer : MonoBehaviour
{
    public int timeLimit = 10;
    private float timeLeft = 600;
    private TextMeshProUGUI timeText;
    private int mins;
    private int sec;

    public AudioSource radio;
    public GameObject radioAlert;
    public AudioSource grandfatherClock;
    private bool alert = false;
    private bool end = false;

    public GameObject fader;

    // Start is called before the first frame update
    void Start()
    {
        timeLeft = timeLimit * 60;
        timeText = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        if(timeLeft <= 120)
        {
            timeText.color = Color.red;
            if (!alert)
            {
                alert = true;
                radio.enabled = false;
                radioAlert.SetActive(true);
                grandfatherClock.Play();
            }
        }
        if (timeLeft < 0)
        {
            timeText.text = "Time\'s up!";
            if(timeLeft < -10 && !end)
            {
                fader.SetActive(true);
                fader.GetComponent<gameOver>().win = false;
                end = true;
            }
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
