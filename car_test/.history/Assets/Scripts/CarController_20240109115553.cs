using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class CarController : MonoBehaviour
{

    public enum Axel
    {

        Front,
        Rear

    }

    [Serializable]
    public struct Wheel
    {

        public GameObject wheelModel;
        public WheelCollider wheelCollider;
        public Axel axel;

    }

    public float maxAcceleration = 30.0f;
    public float brakeAcceleration = 50.0f;

    public float turnSensitivity = 1.0f;
    public float maxSteerAngle = 30.0f;
    public float nitro;

    public Vector3 _centerOfMass;

    public List<Wheel> wheels;

    float moveInput;
    float steerInput;
    float speed;

    private Rigidbody carRb;

    void Start()
    {

        carRb = GetComponent<Rigidbody>();
        carRb.centerOfMass = _centerOfMass;

    }

    void Update()
    {

        GetInput();
        AnimatedWheels();
        SpeedDisplay();

    }

    void LateUpdate()
    {

        Move();
        Steer();
        Brake();

    }

    void GetInput()
    {

        moveInput = Input.GetAxis("Vertical");
        steerInput = Input.GetAxis("Horizontal");

    }

    void Move()
    {

        foreach (var wheel in wheels)
        {

            if (speed <= 150)
            {

                wheel.wheelCollider.motorTorque = moveInput * 1200 * maxAcceleration * nitro * Time.deltaTime;

            }
            else
            {

                wheel.wheelCollider.motorTorque = moveInput * 1 * maxAcceleration * nitro * Time.deltaTime;

            }

        }

    }

    void Nitro()
    {

        if (Input.GetKey(KeyCode.J))
        {

            nitro = 100;

        }
        else
        {

            nitro = 1l

        }

    }

    void Steer()
    {

        foreach (var wheel in wheels)
        {

            if (wheel.axel == Axel.Front)
            {
                var _steerAngle = steerInput * turnSensitivity * maxSteerAngle;
                wheel.wheelCollider.steerAngle = Mathf.Lerp(wheel.wheelCollider.steerAngle, _steerAngle, 0.6f);
            }

        }

    }

    void Brake()
    {

        if (Input.GetKey(KeyCode.Space))
        {

            foreach (var wheel in wheels)
            {

                wheel.wheelCollider.brakeTorque = 100 * brakeAcceleration * 1200 * Time.deltaTime;

            }

        }
        else
        {

            foreach (var wheel in wheels)
            {
                wheel.wheelCollider.brakeTorque = 0;

            }

        }

    }

    void AnimatedWheels()
    {

        foreach (var wheel in wheels)
        {
            Quaternion rot;
            Vector3 pos;
            wheel.wheelCollider.GetWorldPose(out pos, out rot);
            wheel.wheelModel.transform.position = pos;
            wheel.wheelModel.transform.rotation = rot;
        }

    }

    void SpeedDisplay()
    {

        speed = carRb.velocity.magnitude;
        Debug.Log(speed);

    }

}
