using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRLookClickWalk : MonoBehaviour {

	// Assign which camera angles will be monitored
    public Transform vrCamera;

    // Determine the look angle boundaries
    public float topToggleAngle;
    public float bottomToggleAngle;

    // Determine walk speed
    public float walkSpeed;

    // If true, walk forward
    public bool walkForward;

    // Access the character controller
    private CharacterController cc;

    void Start() {
    	// Locate the character controller placed on the XRRig
    	cc = GetComponent<CharacterController>();
    }

    void Update() {

    	// If the x rotation value is within bounds and button is held down, walk
    	if ((vrCamera.eulerAngles.x >= topToggleAngle && vrCamera.eulerAngles.x < bottomToggleAngle) && (Input.GetMouseButton(0))) {
    		walkForward = true;
    	}

    	// if conditions above are not met, stay
    	else {
    		walkForward = false;
    	}

    	// If walking forward, walk forward according to the speed
    	if (walkForward) {
    		Vector3 forward = vrCamera.TransformDirection(Vector3.forward);
    		cc.SimpleMove(forward * walkSpeed);
    	}
    }
}
