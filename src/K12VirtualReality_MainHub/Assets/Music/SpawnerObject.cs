using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;


public class SpawnerObject : MonoBehaviour {

	// Get spawnees and positions dynamically from Unity
    public List<GameObject> spawnees;
    public List<Transform> spawnPositions;

    // Array to be populated with unaltered instrument list as copy
	private GameObject[] spawneesCopy;

	// Constant int to represent the three spawn positions on stage to prevent hardcoding numbers
	const int numSpawnPositions = 3;


	// Use this for initialization
	void Start() {

		// Make an array copy of spawnees list
		spawneesCopy = spawnees.ToArray();

    }
    

    // Update is called once per frame
    void Update() {

    	// Left click
        if(Input.GetKeyDown(KeyCode.Mouse0)) {
        	spawnRandomFinite();
        }

        // Right click
		else if (Input.GetKeyDown(KeyCode.Mouse1)) {
			spawnNewRandom();
        }

    }


	// Jacob Pseudo code
	void spawnNewRandom() {

		// In number of instruments remaining is lass than three 
		if (spawnees.Count < numSpawnPositions) {
			spawnees = new List<GameObject>(spawneesCopy);
		}

		// Shuffle the instruments.
		spawnees = spawnees.OrderBy(x => Random.value).ToList();

		// Use numSpawnPositions variable as limit to spawn in three instruments
		for (int i = 0; i < numSpawnPositions; i++) {

				// Spawn instrument and remove from spawnees list
    			Instantiate(spawnees[0], spawnPositions[i].position, spawnPositions[i].rotation);
    			spawnees.RemoveAt(0);
    	}
	}


    void spawnRandomFinite() {

    	// Shuffle the instruments.
    	spawnees = spawnees.OrderBy(x => Random.value).ToList();


    	// If three or less instruments remain, use spawnees.Count variable as limit to spawn in remaining instruments
    	if (spawnees.Count <= numSpawnPositions) {
    		for (int i = 0; i < spawnees.Count; i++) {

    			// Spawn instrument and remove from spawnees list
    			Instantiate(spawnees[0], spawnPositions[i].position, spawnPositions[i].rotation);
    			spawnees.RemoveAt(0);
    		}
    	}
		
		// If greater than three instruments remain, use numSpawnPositions variable as limit to spawn in three instruments
    	else if (spawnees.Count > numSpawnPositions) {
	   		for (int i = 0; i < numSpawnPositions; i++) {

	   			// Spawn instrument and remove from spawnees list
    			Instantiate(spawnees[0], spawnPositions[i].position, spawnPositions[i].rotation);
    			spawnees.RemoveAt(0);
    		}
	    }

	    // If list is empty, return
		else {
			return;
        }
    }

}