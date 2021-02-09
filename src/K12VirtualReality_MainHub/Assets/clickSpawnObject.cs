using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickSpawnObject : MonoBehaviour {

	public GameObject[] spawnees;
    
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

    	int flag = 0;

    	randomInt1 = Random.Range(0, spawnees.Length);
    	while (flag == 0) {
    		randomInt2 = Random.Range(0, spawnees.Length);
    		if (randomInt2 != randomInt1) {
    			flag = 1;
    		}
    	}
    	
    	flag = 0;

    	while (flag == 0) {
    		randomInt3 = Random.Range(0, spawnees.Length);
    		if ((randomInt3 != randomInt1) && (randomInt3 != randomInt2)) {
    			flag = 1;
    		}
    	}


    	Instantiate(spawnees[randomInt1], spawnPosition1.position, spawnPosition1.rotation);
    	Instantiate(spawnees[randomInt2], spawnPosition2.position, spawnPosition2.rotation);
    	Instantiate(spawnees[randomInt3], spawnPosition3.position, spawnPosition3.rotation);

    }
}