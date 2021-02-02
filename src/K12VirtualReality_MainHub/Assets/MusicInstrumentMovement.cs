using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicInstrumentMovement : MonoBehaviour
{
    public GameObject ins1;
    public GameObject ins2;
    public GameObject ins3;

    public float amplitude = 0.01f;
    public float frequency = 0.5f;

    private GameObject[] instruments;

    private Vector3[] posOffsets;
    private Vector3[] tempPositions;

    // Start is called before the first frame update
    void Start()
    {
        instruments = new GameObject[] { ins1, ins2, ins3 };
        posOffsets = new Vector3[] { ins1.transform.position, ins2.transform.position, ins3.transform.position };
        tempPositions = new Vector3[3];
    }

    // Update is called once per frame
    void Update()
    {
        for(int i = 0; i < instruments.Length; i++)
        {
            tempPositions[i] = posOffsets[i];
            tempPositions[i].y += Mathf.Sin(Time.fixedTime * Mathf.PI * frequency) * amplitude;

            instruments[i].transform.position = tempPositions[i];
        }
    }
}
