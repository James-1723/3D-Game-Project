using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    public ParticleSystem effect;
    public float xSpeed = 0.0f;
    public float ySpeed = 0.0f;
    public float zSpeed = 0.0f;
    private bool isTriggered = false;
    private TimeManager timeManager;


    void Start()
    {

        effect = GetComponent<ParticleSystem>();
        //timeManager = FindObjectOfType<TimeManager>();

    }

    void Update()
    {

        transform.Rotate(
            xSpeed * Time.deltaTime,
            ySpeed * Time.deltaTime,
            zSpeed * Time.deltaTime
        );

    }


    void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player") && !isTriggered)
        {

            effect.Play();
            Destroy(gameObject, 0.1f);
            isTriggered = true;

            if (timeManager != null)
            {

                timeManager.IncreaseTime();

            }

        }
    }

}
