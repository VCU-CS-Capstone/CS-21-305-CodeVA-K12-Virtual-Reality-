using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicInstrumentMovement : MonoBehaviour {

    // Reference to which instrument will be floating
	public GameObject instrument;
    
    // Determine what range the instrument will float within
    public float amplitude = 0.025f;
    public float frequency = 0.5f;

    // Determine positions instrument will float between
    private Vector3 posOffset;
    private Vector3 tempPosition;

    // Start is called before the first frame update
    void Start() {

        // Set initial position of instrument
        posOffset = instrument.transform.position;
        
    }

    // Update is called once per frame
    void Update() {
        
        // Set temp position to original position, move to new calulated position, return to original position
    	tempPosition = posOffset;
    	tempPosition.y += Mathf.Sin(Time.fixedTime * Mathf.PI * frequency) * amplitude;
    	instrument.transform.position = tempPosition;

    }
}
