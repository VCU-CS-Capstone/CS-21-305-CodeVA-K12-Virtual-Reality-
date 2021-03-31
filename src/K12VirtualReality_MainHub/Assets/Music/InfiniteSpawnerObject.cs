using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;

public class InfiniteSpawnerObject : MonoBehaviour
{

    // Get spawnees and positions dynamically from Unity
    public List<GameObject> spawnees;
    public List<Transform> spawnPositions;
    public GameObject[] cache;
    public List<AudioSource> audioSources;
    public GameObject CorrectAudio;
    public GameObject IncorrectAudio;

    public Button Left;
    public Button Right;
    public Button Middle;

    public TMPro.TextMeshProUGUI leftButton;
    public TMPro.TextMeshProUGUI middleButton;
    public TMPro.TextMeshProUGUI rightButton;

    public TMPro.TextMeshProUGUI correctScoreText;
    public TMPro.TextMeshProUGUI incorrectScoreText;

    private int correctScore;
    private int incorrectScore;
    private int correctInstrument;

    // Array to be populated with unaltered instrument list as copy
    private GameObject[] spawneesCopy;

    // Constant int to represent the three spawn positions on stage to prevent hardcoding numbers
    const int numSpawnPositions = 3;

    // Use this for initialization
    void Start()
    {

        correctScore = 0;
        incorrectScore = 0;
        // Make an array copy of spawnees list
        spawneesCopy = spawnees.ToArray();

        cache = new GameObject[3];
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

public void UpdateScore(int value)
    {
        Debug.Log(value);
        
        ButtonControl("OFF");

        if(value == correctInstrument)
        {
            correctScore++;
            correctScoreText.text = correctScore.ToString();
            SetAudioClips(CorrectAudio);
        }
        else
        {
            incorrectScore++;
            incorrectScoreText.text = incorrectScore.ToString();
            SetAudioClips(IncorrectAudio);
        }
        correctInstrument = -1;
    }


    public void Clear() {
    	foreach(var aus in audioSources)
        {
            aus.clip = null;
        }

        for(int i = 0; i < cache.Length; i++)
        {
            Destroy(cache[i]);
            cache[i] = null;
        }

        correctInstrument = -1;


    
    }

    public void spawnRandomInfinite()
    {

        // In number of instruments remaining is lass than three 
        if (spawnees.Count < numSpawnPositions)
        {
            spawnees = new List<GameObject>(spawneesCopy);
        }

        // Shuffle the instruments.
        ShuffleInstruments();


        ButtonControl("ON");


        // Use numSpawnPositions variable as limit to spawn in three instruments
        for (int i = 0; i < numSpawnPositions; i++)
        {

            // Spawn instrument and remove from spawnees list
            GameObject g = Instantiate(spawnees[0], spawnPositions[i].position, spawnPositions[i].rotation) as GameObject;
            cache[i] = g;

            spawnees.RemoveAt(0);
        }

        SetButtonNames();
        SelectCorrectInstrument();
        SetAudioClips(cache[correctInstrument]);
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
        foreach (var auso in audioSources)
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

    public void PauseBeforeSpawn(string method){
    	if (method == "Clear"){
    		Invoke("Clear", 2);
    	}
    	else if (method == "spawnRandomInfinite"){
    		Invoke("spawnRandomInfinite", 2);
    	}
    }

    private void ButtonControl(string command){
    	if (command == "ON"){
    		Left.interactable = true;
        	Right.interactable = true;
        	Middle.interactable = true;
    	}
    	else if (command == "OFF"){
    		Left.interactable = false;
        	Right.interactable = false;
        	Middle.interactable = false;
    	}
    }

}