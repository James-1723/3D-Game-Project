using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{

    public float timeRemaining = 10.0f;
    public bool timeIsRunning = false;
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

        float minutes = Mathf.FloatToInt(timeToDisplay / 60);

    }

}
