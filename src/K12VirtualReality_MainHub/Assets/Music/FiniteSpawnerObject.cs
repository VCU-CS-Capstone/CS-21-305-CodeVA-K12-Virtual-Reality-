using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;


public class FiniteSpawnerObject : MonoBehaviour {

	// Get spawnees and positions dynamically from Unity
    public List<GameObject> spawnees;
    public List<Transform> spawnPositions;
    public GameObject[] cache;
    public List<AudioSource> audioSources;

    public TMPro.TextMeshProUGUI leftButton;
    public TMPro.TextMeshProUGUI middleButton;
    public TMPro.TextMeshProUGUI rightButton;

    public TMPro.TextMeshProUGUI correctScoreText;
    public TMPro.TextMeshProUGUI incorrectScoreText;

    public TMPro.TextMeshProUGUI currentRoundText;

    private int correctScore;
    private int incorrectScore;
    private int currentRound;
    private int correctInstrument;

    // Array to be populated with unaltered instrument list as copy
	private GameObject[] spawneesCopy;

	// Constant int to represent the three spawn positions on stage to prevent hardcoding numbers
	const int numSpawnPositions = 3;

	// Use this for initialization
	void Start() {

        correctScore = 0;
        incorrectScore = 0;
        currentRound = 0;
		// Make an array copy of spawnees list
		spawneesCopy = spawnees.ToArray();

        cache = new GameObject[3];

        ShuffleInstruments();
    }

    // Time remaining before the audio plays again.
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
        Debug.Log(value);
        for(int i = 0; i < cache.Length; i++)
        {
            Destroy(cache[i]);
            cache[i] = null;
        }

        if(value == correctInstrument)
        {
            correctScore++;
            correctScoreText.text = correctScore.ToString();
        }
        else
        {
            incorrectScore++;
            incorrectScoreText.text = incorrectScore.ToString();
        }


        foreach(var aus in audioSources)
        {
            aus.clip = null;
        }

        correctInstrument = -1;

        leftButton.text = "Select";
        middleButton.text = "Select";
        rightButton.text = "Select";
    }

    public void spawnRandomFinite() {
        if (spawnees.Count == 0) return; // TODO: Handle the exiting game scenario here!

	   	for (int i = 0; i < numSpawnPositions; i++) {
    		cache[i] = Instantiate(spawnees[0], spawnPositions[i].position, spawnPositions[i].rotation) as GameObject;
    		spawnees.RemoveAt(0);
    	}

        SetButtonNames();
        SelectCorrectInstrument();
        SetAudioClips(cache[correctInstrument]);
        currentRound++;
        currentRoundText.text = $"{currentRound.ToString()}/10";
    }

    private void SetButtonNames()
    {
        leftButton.text = GetNameWithoutClone(cache[0].name);
        middleButton.text = GetNameWithoutClone(cache[1].name);
        rightButton.text = GetNameWithoutClone(cache[2].name);
    }

    private string GetNameWithoutClone(string name)
    {
        return name.Split('(')[0];
    }

    private void SetAudioClips(GameObject obj)
    {
        Debug.Log(obj.name);
        AudioSource a = GameObject.Find(obj.name).GetComponent<AudioSource>();
        foreach(var auso in audioSources)
        {
            auso.clip = a.clip;
        }

        audioSources[0].Play();
        audioSources[1].Play();
        audioSources[2].Play();
        audioSources[3].Play();
    }

    private void ShuffleInstruments()
    {
        spawnees = spawnees.OrderBy(x => Random.value).ToList();
    }

    private void SelectCorrectInstrument()
    {
        correctInstrument = (int)Random.Range(0, 3);
    }

}