using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectFaceCamera : MonoBehaviour {

	private Transform cameraToFace;

    // Start is called before the first frame update
    void Start() {

    	cameraToFace = Camera.main.transform;
        
    }


    // Update is called once per frame
    void Update() {

    	transform.LookAt(cameraToFace);
        
    }
}
