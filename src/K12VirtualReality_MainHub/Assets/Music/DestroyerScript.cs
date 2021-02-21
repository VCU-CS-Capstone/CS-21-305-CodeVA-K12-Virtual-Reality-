using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyerScript : MonoBehaviour {

    public GameObject objectToDestroy;
    
    public void Destruction() {
    	Destroy(objectToDestroy);
    }

}