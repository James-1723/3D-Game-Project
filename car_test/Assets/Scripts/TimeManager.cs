using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimeManager : MonoBehaviour
{

    public ParticleSystem effect;
    public static float timeRemaining = 10.0f;
    public bool timeIsRunning = false;
    public Text timeText;
    public bool gameStart;
    public float xSpeed = 0.0f;
    public float ySpeed = 0.0f;
    public float zSpeed = 0.0f;

    public TextMeshProUGUI timerText;

    void Start()
    {

        effect = GetComponent<ParticleSystem>();
        timeIsRunning = true;
        gameStart = false;
        StartCoroutine(DisplayTimeCoroutine());


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

        DisplayTime(timeRemaining);

    }

    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeRemaining % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);

    }

    IEnumerator DisplayTimeCoroutine()
    {
        while (timeRemaining > 0)
        {
            DisplayTime(timeRemaining);

            if (timeRemaining <= 4.0f)
            {
                timerText.color = Color.red;
                timerText.enabled = !timerText.enabled;
                yield return new WaitForSeconds(0.1f); // Adjust the interval as needed
            }

            yield return null; // This ensures the coroutine waits for the next frame before continuing
        }
        timerText.enabled = true;
    }

    public void IncreaseTime()
    {

        timeRemaining += 5.0f;

    }

}
