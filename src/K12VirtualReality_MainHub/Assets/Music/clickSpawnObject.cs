using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickSpawnObject : MonoBehaviour {

	//public GameObject[] spawnees;
    public List<GameObject> spawnees;

    public Transform spawnPosition1;
    public Transform spawnPosition2;
    public Transform spawnPosition3;

    int randomInt1;
    int randomInt2;
    int randomInt3;

    

    // Update is called once per frame
    void Update() {
        if(Input.GetKeyDown(KeyCode.Mouse0)) {
        	spawnRandom();
        }
    }

    void spawnRandom() {

    	if (spawnees.Count == 3) {
    		Instantiate(spawnees[0], spawnPosition1.position, spawnPosition1.rotation);
	   		Instantiate(spawnees[1], spawnPosition2.position, spawnPosition2.rotation);
	   		Instantiate(spawnees[2], spawnPosition3.position, spawnPosition3.rotation);
	   		spawnees.RemoveAt(2);
	   		spawnees.RemoveAt(1);
	   		spawnees.RemoveAt(0);

    	}

    	else if (spawnees.Count > 3) {
	    	int flag = 0;

	   		//randomInt1 = Random.Range(0, spawnees.Length);

	   		randomInt1 = Random.Range(0, (spawnees.Count - 1));
	   		while (flag == 0) {
	   			//randomInt2 = Random.Range(0, spawnees.Length);
    			randomInt2 = Random.Range(0, (spawnees.Count - 1));
    			if (randomInt2 != randomInt1) {
	    			flag = 1;
	   			}
	   		}
	    	
	   		flag = 0;

	   		while (flag == 0) {
	    		//randomInt3 = Random.Range(0, spawnees.Length);
	   			randomInt3 = Random.Range(0, (spawnees.Count - 1));
	   			if ((randomInt3 != randomInt1) && (randomInt3 != randomInt2)) {
	   				flag = 1;
	   			}
    		}


	   		Instantiate(spawnees[randomInt1], spawnPosition1.position, spawnPosition1.rotation);
	   		Instantiate(spawnees[randomInt2], spawnPosition2.position, spawnPosition2.rotation);
	   		Instantiate(spawnees[randomInt3], spawnPosition3.position, spawnPosition3.rotation);

	   		if (randomInt1 < randomInt2) {
    			randomInt2 = randomInt2 - 1;
    		}
	   		if (randomInt1 < randomInt3) {
	   			randomInt3 = randomInt3 - 1;
	   		}


	   		if (randomInt2 < randomInt3) {
	   			randomInt3 = randomInt3 - 1;
    		}



	   		spawnees.RemoveAt(randomInt1);
    		spawnees.RemoveAt(randomInt2);
	   		spawnees.RemoveAt(randomInt3);
	    }

	    else {
	    	return;
	    }
    }

}