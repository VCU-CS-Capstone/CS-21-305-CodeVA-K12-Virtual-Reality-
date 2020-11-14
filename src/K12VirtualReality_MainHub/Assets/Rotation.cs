using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public Vector3 rotation;
    public float hoursPerDay;
    private float speedConstant = 420f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 rotationCalculated = rotation;
        if (hoursPerDay != 0)
            rotationCalculated = rotation * Time.deltaTime / hoursPerDay * speedConstant;
        transform.Rotate(rotationCalculated);
    }
}