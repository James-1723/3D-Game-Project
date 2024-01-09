using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleSys : MonoBehaviour
{

    ParticleSystem effect;

    void Start()
    {

        effect = GetComponent<ParticleSystem>();

    }

    void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Player")
        {

            effect.Play();

        }

    }

}

