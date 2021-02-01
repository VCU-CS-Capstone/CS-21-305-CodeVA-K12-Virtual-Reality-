using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickSpawnObject : MonoBehaviour {
    
    public Transform spawnPosition1;
    public Transform spawnPosition2;
    public Transform spawnPosition3;
    public GameObject spawnee;

    // Update is called once per frame
    void Update() {
        if(Input.GetButton()) {
        	Instantiate(spawnee, spawnPosition1.position, spawnPosition1.rotation);
        	Instantiate(spawnee, spawnPosition2.position, spawnPosition2.rotation);
        	Instantiate(spawnee, spawnPosition3.position, spawnPosition3.rotation);
        }
    }
}
