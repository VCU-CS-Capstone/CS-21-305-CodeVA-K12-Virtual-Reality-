using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class EllipticalOrbit : MonoBehaviour
{
    // Float to hold the days per one revolution.
    public float DaysPerRevolution;
    // Float to hold the radius of the orbit.
    public float Radius;
    // Float to hold the width in the Z axis of the orbit.
    public float ZWidth;
    // Float to hold the width in the X axis of the orbit.
    public float XWidth;
    // Float to hold the current time.
    private float _Time;
    // Float to hold the speed constant.
    private float _SpeedConstant;

    // Start is called before the first frame update
    void Start()
    {
        // Set the speed constant to an arbitrary 15.0f.
        _SpeedConstant = 15.0f;
        // Set the width in the X axis to 1.0f.
        XWidth = 1.0f;
        // Set the width in the Z axis to 1.0f.
        ZWidth = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        _Time = Time.time;
        // Using the mathematical formula for an ellipses
        // (X/A)^2 + (Z/B)^2 = R^2
        // Where X = R*sin(t) and Z = R*cos(t)
        // and A and B are XWidth and ZWidth
        transform.position = new Vector3(Radius * (float)(Math.Sin(_SpeedConstant * _Time / DaysPerRevolution) / XWidth), 0, Radius * (float)(Math.Cos(_SpeedConstant * _Time / DaysPerRevolution)) / ZWidth);
    }
}
