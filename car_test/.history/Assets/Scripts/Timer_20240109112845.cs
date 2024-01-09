using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    public float timeRemaining = 10.0f;
    public bool timeIsRunning = false;

    public Text timeText;
    void Start()
    {

        timeIsRunning = true;

    }

    void Update()
    {

        if (timeRemaining > 0)
        {

            timeRemaining -= Time.deltaTime;

        }
        else
        {

            Debug.Log("Time has run out");
            timeRemaining = 0;
            timeIsRunning = false;

        }

    }

    void DisplayTime(float timeToDisplay)
    {

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeRemaining % 60);
        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);

    }

}
