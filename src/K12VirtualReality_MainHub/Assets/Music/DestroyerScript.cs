using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyerScript : MonoBehaviour {
    
    public float lifeTime = 10.0f;

    // Update is called once per frame
    void Update() {
        if (lifeTime > 0) {
        	lifeTime -= Time.deltaTime;
        	if (lifeTime <= 0) {
        		Destruction();
        	}
        }
    }

    void Destruction() {
    	Destroy(this.gameObject);
    }
}
