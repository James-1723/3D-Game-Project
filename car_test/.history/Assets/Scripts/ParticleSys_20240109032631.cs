using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleSys : MonoBehaviour
{

    public ParticleSystem effect;
    public GameObject cars;

    void Start()
    {

        effect = GetComponent<ParticleSystem>();

    }

    void OnTriggerEnter(Collider other)
    {

        if (other.name == "Chevy")
        {

            Debug.Log("Hit");
            effect.Play();

        }

    }

}


