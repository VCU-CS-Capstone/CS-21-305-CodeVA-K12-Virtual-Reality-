using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicInstrumentMovement : MonoBehaviour {

	public GameObject instrument;
    
 
    public float amplitude = 0.025f;
    public float frequency = 0.5f;

    private Vector3 posOffset;
    private Vector3 tempPosition;

    // Start is called before the first frame update
    void Start() {

        posOffset = instrument.transform.position;
        
    }

    // Update is called once per frame
    void Update() {
        
    	tempPosition = posOffset;
    	tempPosition.y += Mathf.Sin(Time.fixedTime * Mathf.PI * frequency) * amplitude;
    	instrument.transform.position = tempPosition;

    }
}
