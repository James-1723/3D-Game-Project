using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    ParticleSystem effect;

    void Start()
    {

        effect = GetComponent<ParticleSystem>();

    }

    void OnTriggerEnter(Collider other)
    {

        effect.Play();

    }

}


