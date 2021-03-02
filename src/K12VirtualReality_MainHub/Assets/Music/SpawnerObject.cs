using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;


public class SpawnerObject : MonoBehaviour {

	// Get spawnees and positions dynamically from Unity
    public List<GameObject> spawnees;
    public List<Transform> spawnPositions;
    public GameObject[] cache;
    public TMPro.TextMeshProUGUI scoreboardText;
    public List<AudioSource> audioSources;

    private int score;
    private int correctInstrument;

    // Array to be populated with unaltered instrument list as copy
	private GameObject[] spawneesCopy;

	// Constant int to represent the three spawn positions on stage to prevent hardcoding numbers
	const int numSpawnPositions = 3;


	// Use this for initialization
	void Start() {

		// Make an array copy of spawnees list
		spawneesCopy = spawnees.ToArray();

        cache = new GameObject[3];
        score = 0;
        scoreboardText.text = $"Score: {score}";
    }

    private float timeRemaining = 10.0f;

    void Update()
    {
        if (correctInstrument != -1)
        {
            if (timeRemaining > 0.0f) timeRemaining -= Time.deltaTime;
            else
            {
                timeRemaining = 10.0f;
                audioSources[0].Play();
                audioSources[1].Play();
                audioSources[2].Play();
                audioSources[3].Play();
            }
        }
    }
    
    public void Clear(int value)
    {
        for(int i = 0; i < cache.Length; i++)
        {
            Destroy(cache[i]);
            cache[i] = null;
        }
        if(value == correctInstrument)
        {
            scoreboardText.text = $"Score: {++score}";
        }

        correctInstrument = -1;
    }

	// Jacob Pseudo code
	public void spawnRandomInfinite() {

		// In number of instruments remaining is lass than three 
		if (spawnees.Count < numSpawnPositions) {
			spawnees = new List<GameObject>(spawneesCopy);
		}

        // Shuffle the instruments.
        ShuffleInstruments();

		// Use numSpawnPositions variable as limit to spawn in three instruments
		for (int i = 0; i < numSpawnPositions; i++) {

		    // Spawn instrument and remove from spawnees list
            GameObject g = Instantiate(spawnees[0], spawnPositions[i].position, spawnPositions[i].rotation) as GameObject;
            cache[i] = g;

    		spawnees.RemoveAt(0);
    	}

        SelectCorrectInstrument();
        SetAudioClips(cache[correctInstrument]);
	}


    public void spawnRandomFinite() {

        // Shuffle the instruments.
        ShuffleInstruments();


    	// If three or less instruments remain, use spawnees.Count variable as limit to spawn in remaining instruments
    	if (spawnees.Count <= numSpawnPositions) {
    		for (int i = 0; i < spawnees.Count; i++) {

    			// Spawn instrument and remove from spawnees list
    			cache[i] = Instantiate(spawnees[0], spawnPositions[i].position, spawnPositions[i].rotation) as GameObject;
    			spawnees.RemoveAt(0);
    		}
    	}
		
		// If greater than three instruments remain, use numSpawnPositions variable as limit to spawn in three instruments
    	else if (spawnees.Count > numSpawnPositions) {
	   		for (int i = 0; i < numSpawnPositions; i++) {

	   			// Spawn instrument and remove from spawnees list
    			cache[i] = Instantiate(spawnees[0], spawnPositions[i].position, spawnPositions[i].rotation) as GameObject;
    			spawnees.RemoveAt(0);
    		}
	    }

	    // If list is empty, return
		else {
			return;
        }

        SelectCorrectInstrument();
        SetAudioClips(cache[correctInstrument]);
    }

    private void SetAudioClips(GameObject obj)
    {
        Debug.Log(obj.name);
        AudioSource a = GameObject.Find(obj.name).GetComponent<AudioSource>();
        foreach(var auso in audioSources)
        {
            auso.clip = a.clip;
        }
    }

    private void ShuffleInstruments()
    {
        spawnees = spawnees.OrderBy(x => Random.value).ToList();
    }

    private void SelectCorrectInstrument()
    {
        correctInstrument = (int)Random.Range(0, 2);
    }

}