using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectFaceCamera : MonoBehaviour {

	// Variable to indicate which camera all instruments will face
	private Transform cameraToFace;

    // Start is called before the first frame update
    void Start() {

    	// Assign which camera will be faced
    	cameraToFace = Camera.main.transform;
        
    }

    // Update is called once per frame
    void Update() {

    	// Look at the camera
    	transform.LookAt(cameraToFace);
        
    }
}
