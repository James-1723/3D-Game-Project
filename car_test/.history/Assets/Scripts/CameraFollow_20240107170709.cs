using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public float moveSmoothness = 10f;
    public float rotSmoothness = 7f;

    public Vector3 moveOffset;
    public Vector3 rotOffset;

    public Transform carTarget;

    void FixedUpdate()
    {

        FollowTarget();

    }

    void FollowTarget()
    {

        HandledMovement();
        HandledRotation();

    }

    void HandledMovement()
    {

        Vector3 targetPos = new Vector3();
        targetPos = carTarget.TransformPoint(moveOffset);
        transform.position = Vector3.Lerp(transform.position, targetPos, moveSmoothness * Time.deltaTime);

    }

    void HandledRotation()
    {

        var direction = carTarget.position - transform.position;
        var rotation = new Quaternion();
        rotation = Quaternion.LookRotation(direction + rotOffset, Vector3.up);
        transform.rotation = Quaternion.Lerp(transform.rotation, rotation, rotSmoothness * Time.deltaTime);

    }

}
