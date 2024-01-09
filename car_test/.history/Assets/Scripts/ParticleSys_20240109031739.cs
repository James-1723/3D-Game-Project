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

        if (other.gameObject.CompareTag("Player"))
        {

            effect.Play();

        }

    }

}


