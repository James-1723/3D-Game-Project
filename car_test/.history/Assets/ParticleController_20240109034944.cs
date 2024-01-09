using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleController : MonoBehaviour
{
    ParticleSystem effect;
    public float xSpeed = 0.0f;
    public float ySpeed = 0.0f;
    public float zSpeed = 0.0f;
    void Start()
    {

        effect = GetComponent<ParticleSystem>();

    }

    // Update is called once per frame
    void Update()
    {

        transform.Rotate();

    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {

            effect.Play();
            Destroy(gameObject, 1);

        }

    }

}
