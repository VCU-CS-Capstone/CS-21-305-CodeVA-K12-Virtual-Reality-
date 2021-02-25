using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class DestroyerScript : MonoBehaviour {

	GameObject[] InstrumentsToDestroy;
	    
	public void Destruction (){
    	
    	InstrumentsToDestroy = GameObject.FindGameObjectsWithTag("Instrument");

    	foreach(GameObject instrument in  InstrumentsToDestroy) {
    		Destroy(instrument);
    	}
    
	}
}