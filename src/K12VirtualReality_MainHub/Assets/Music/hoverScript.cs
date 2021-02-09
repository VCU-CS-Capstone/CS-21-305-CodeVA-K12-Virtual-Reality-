/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hoverScript : MonoBehaviour {

	public GameObject gameObject;
    
    public float maxHeight;
    public float minHeight;
    public float hoverSpeed;

    void Update() {
        float hoverHeight = (maxHeight + minHeight) / 2.0f;
        float hoverRange = maxHeight - minHeight;

        gameObject.transform.position = Vector3.up * (hoverHeight + Mathf.Cos(Time.time * hoverSpeed) * hoverRange);
    }
}
*/