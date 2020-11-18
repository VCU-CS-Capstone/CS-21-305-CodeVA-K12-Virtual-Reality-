using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Revolution : MonoBehaviour
{
    // Float to hold the number of days per year.
    public float DaysPerYear;
    // Three component vector to hold the revolution of the object.
    public Vector3 RevolutionVector;
    // The game object to revolve around.
    public GameObject ObjectToRevolveAround;

    // Float for constant speed value. 
    private float speedConstant;

    // Start is called before the first frame update
    void Start()
    {
        // Set the speed constant to an arbitrary float of 3000.0f.
        speedConstant = 3000.0f;
    }

    // Update is called once per frame
    void Update()
    {
        // Check if any of the axis of the revolution vector is zero.
        // If any of the axis are zero, set the revolution vector to Vector3.up so that the math will still work.
        if (RevolutionVector.x == 0 && RevolutionVector.y == 0 && RevolutionVector.z == 0) RevolutionVector = Vector3.up;

        // Calculate the angle in which we want to rotate by dividing deltaTime by the product
        // of daysPerYear and speedConstant.
        float angle = Time.deltaTime / DaysPerYear * speedConstant;

        // Transform the object using the RotateAround function, passing in the following:
        // - Transform position of the object we want to revolve around.
        // - The new revolution vector.
        // - The angle in which we want to rotate around.
        transform.RotateAround(ObjectToRevolveAround.transform.position, RevolutionVector, angle);
    }
}
