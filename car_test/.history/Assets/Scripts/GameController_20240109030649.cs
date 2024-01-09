using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    ParticleSystem puzzle;

    void OnTriggerEnter(Collider other)
    {

        puzzle.Play();

    }

}


