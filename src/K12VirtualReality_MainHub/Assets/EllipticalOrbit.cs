using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class EllipticalOrbit : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    public Vector3 center = new Vector3(0, 0, 0);
    public float daysPerRevolution = 1.0f;
    public float radius = 1f;
    private float t;
    private float speedConstant = 15;
    public float x_width = 1;
    public float z_width = 1;

    // Update is called once per frame
    void Update()
    {
        //speed = speed * 0.15;
        t = Time.time;
        transform.position = new Vector3(radius * (float)(Math.Sin(speedConstant * t / daysPerRevolution) / x_width), 0, radius * (float)(Math.Cos(speedConstant * t / daysPerRevolution)) / z_width);
    }
}