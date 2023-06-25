using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ventilator : MonoBehaviour
{
    public HingeJoint hingeJoint;
    public Wind viento;

    private void Update()
    {
        JointMotor motor = hingeJoint.motor;
        motor.targetVelocity = viento.GetWindForce() * 500f;
        hingeJoint.motor = motor;
        hingeJoint.useMotor = true;
    }
}
