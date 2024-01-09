using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{

    public ParticleSystem effect;
    public float timeRemaining = 10.0f;
    public bool timeIsRunning = false;
    public Text timeText;
    public bool gameStart;
    public float xSpeed = 0.0f;
    public float ySpeed = 0.0f;
    public float zSpeed = 0.0f;


    void Start()
    {

        effect = GetComponent<ParticleSystem>();
        timeIsRunning = true;
        gameStart = false;


    }

    void Update()
    {

        if (timeIsRunning)
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


    }

    void DisplayTime(float timeToDisplay)
    {

        timeToDisplay += 1;
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeRemaining % 60);
        //timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);

    }

    public void IncreaseTime()
    {

        timeRemaining += 5.0f;

    }

}
