using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    ParticleSystem puzzle;

    void Start()
    {

        puzzle = GetComponent<ParticleSystem>();

    }

    void OnTriggerEnter(Collider other)
    {

        puzzle.Play();

    }

}


