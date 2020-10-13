using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Revolution : MonoBehaviour
{
    public new GameObject gameObject;
    public float speed;
    public Vector3 revolutionVector;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (revolutionVector.x == 0 && revolutionVector.y == 0 && revolutionVector.z == 0) revolutionVector = Vector3.up;
        transform.RotateAround(gameObject.transform.position, revolutionVector, speed * Time.deltaTime);
    }
}
