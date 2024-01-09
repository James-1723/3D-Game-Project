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

    private void OnTriggerEnter(Collision other)
    {

        if (other.gameObject.CompareTag("Player"))
        {

            effect.Play();
            Destroy(gameObject);

        }

    }

}
