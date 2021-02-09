using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    // Three component vector to hold the rotation of the object.
    public Vector3 RotationVector;
    // Float to contain the number of hours per day.
    public float HoursPerDay;
    // Float for constant speed value.
    private float _SpeedConstant;

    // Start is called before the first frame update
    void Start()
    {
        // Set the speed constant to an arbitrary float of 420.0f.
        _SpeedConstant = 420.0f;
    }

    // Update is called once per frame
    void Update()
    {
        // Create a new three component vector to hold the previous rotation.
        Vector3 newRotation = Vector3.zero;

        // Check that the hours per day is not equal to zero.
        // If the hours per day is zero then there would be no rotation.
        if (HoursPerDay != 0.0f)
        {
            // Once the check is completed, multiply the old rotation by
            // Time.deltaTime. Then divide that product by the product from hoursPerDay times the speedConstant.
            float rotationTime = Time.deltaTime / HoursPerDay;
            newRotation = rotationTime * RotationVector * _SpeedConstant;
        }

        // Finally, transform the object using the rotationCalculated vector.
        transform.Rotate(newRotation);
    }
}