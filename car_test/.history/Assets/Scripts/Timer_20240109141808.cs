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


    void Start()
    {

        effect = GetComponent<ParticleSystem>();

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

            timeRemaining += 5.0f;
            effect.Play();
            Destroy(gameObject, 0.1f);
            isTriggered = true;

        }
    }

}
