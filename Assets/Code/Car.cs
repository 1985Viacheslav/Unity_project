using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    public Rigidbody rigidbody;

    public WheelCollider rightFrontWheel;
    public WheelCollider leftFrontWheel;
    public WheelCollider rightBackWheel;
    public WheelCollider leftBackWheel;

    public Transform rightFrontWheelView;
    public Transform leftFrontWheelView;
    public Transform rightBackWheelView;
    public Transform leftBackWheelView;

    public Vector3 centerMass;

    public float acceleration = 500f;
    public float breakingForce = 300f;
    public float rotateSpeed = 15f;

    private float _currentAcceleration;
    private float _currentBreakingForce;
    private float _currentRotateAngle;

    private void Start()
    {
        rigidbody.centerOfMass = centerMass;
    }

    private void FixedUpdate()
    {
        _currentAcceleration = acceleration * Input.GetAxis("Vertical");
        _currentRotateAngle = rotateSpeed * Input.GetAxis("Horizontal");

        if (Input.GetKey(KeyCode.Space))
        {
            _currentBreakingForce = breakingForce;
        }
        else
        {
            _currentBreakingForce = 0;
        }

        rightFrontWheel.motorTorque = _currentAcceleration;
        leftFrontWheel.motorTorque = _currentAcceleration;

        rightFrontWheel.steerAngle = _currentRotateAngle;
        leftFrontWheel.steerAngle = _currentRotateAngle;

        rightBackWheel.brakeTorque = _currentBreakingForce;
        leftBackWheel.brakeTorque = _currentBreakingForce;
        rightFrontWheel.brakeTorque = _currentBreakingForce;
        leftBackWheel.brakeTorque = _currentBreakingForce;
    }

    private void Update()
    {
        UpdateWheel(rightFrontWheel, rightFrontWheelView);
        UpdateWheel(rightBackWheel, rightBackWheelView);
        UpdateWheel(leftBackWheel, leftBackWheelView);
        UpdateWheel(leftFrontWheel, leftFrontWheelView);
    }

    private void UpdateWheel(WheelCollider wheelCollider, Transform view)
    {
        wheelCollider.GetWorldPose(out var position, out var rotation);
        view.position = position;
        view.rotation = rotation;
    }
}
