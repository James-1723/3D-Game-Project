using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Timing : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    public float timing = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DisplayTimeCoroutine());

    }

    // Update is called once per frame
     void Update()
    {
        
        timing += Time.deltaTime;
        DisplayTime(timing);

    }

    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timing % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);

    }

    IEnumerator DisplayTimeCoroutine()
    {
        while (timing >= 0)
        {
            DisplayTime(timing);

            yield return null; // This ensures the coroutine waits for the next frame before continuing
        }
        timerText.enabled = true;
    }

}
