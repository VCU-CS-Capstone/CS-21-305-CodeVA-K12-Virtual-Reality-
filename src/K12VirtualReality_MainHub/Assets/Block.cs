using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class RevolutionCustom : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    public Vector3 center = new Vector3(0, 0, 0);
    public float speed = 1.0f;

    public float radius = 1f;
    float t;
    public float x_width=1;
    public float z_width=1;
    public float speedModifier = 0.15f;
    //   public Vector3 pos1 = new Vector3(-10000+(Time.time*100),0,17000);
    //   public Vector3 pos2;

    // Update is called once per frame
    void Update()
    {
        t=Time.time*speed*speedModifier;
        transform.position = new Vector3(radius*(float)(Math.Sin(t)/x_width),0,radius*(float)(Math.Cos(t))/z_width);
    }
}