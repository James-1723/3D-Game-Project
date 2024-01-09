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

    private void OnTriggerStay(Collider other)
    {

        if (other.CompareTag("Player"))
        {

            effect.Play();
            Destroy(gameObject);

        }

    }

}
