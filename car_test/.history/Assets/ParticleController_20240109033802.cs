using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleController : MonoBehaviour
{
    ParticleSystem effect;
    void Start()
    {

        effect = GetComponent<ParticleSystem>();

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnColliderEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Player"))
        {

            effect.Play();

        }

    }

}
