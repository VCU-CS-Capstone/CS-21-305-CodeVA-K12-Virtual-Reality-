using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Add these to be able to shuffle instruments and reference UI elements
using System.Linq;
using UnityEngine.UI;

public class InfiniteSpawnerObject : MonoBehaviour
{

    // Spawnees, positions, and audio assigned in Unity
    public List<GameObject> spawnees;
    public List<Transform> spawnPositions;
    public GameObject[] cache;
    public List<AudioSource> audioSources;
    public GameObject CorrectAudio;
    public GameObject IncorrectAudio;

    // Reference left, right, and middle select buttons assigned in Unity
    public Button Left;
    public Button Right;
    public Button Middle;

    // Reference text fro left, rigth, and middle select buttons assigned in Unity
    public TMPro.TextMeshProUGUI leftButton;
    public TMPro.TextMeshProUGUI middleButton;
    public TMPro.TextMeshProUGUI rightButton;

    // Reference text for correct and incorrect headers assigned in Unity
    public TMPro.TextMeshProUGUI correctScoreText;
    public TMPro.TextMeshProUGUI incorrectScoreText;

    // Variables for setting score and instrument
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

    	// Set initial scores to 0
        correctScore = 0;
        incorrectScore = 0;

        // Make an array copy of spawnees list
        spawneesCopy = spawnees.ToArray();

        // Initialize cache array
        cache = new GameObject[3];
    }

    // Time remaining before the audio plays again.
    private float timeRemaining = 10.0f;



    // Update is called once per frame
    void Update()
    {

    	// If the correct instrument exists, play its audio every ten seconds
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
        
        // Turn buttons off once answer is selected
        ButtonControl("OFF");

        // If correct answer selected, increase correct score  and play correct audio feedback 
        if(value == correctInstrument)
        {
            correctScore++;
            correctScoreText.text = correctScore.ToString();
            SetAudioClips(CorrectAudio);
        }

        // Else, increase incorrect score and play incorrect audio feedback
        else
        {
            incorrectScore++;
            incorrectScoreText.text = incorrectScore.ToString();
            SetAudioClips(IncorrectAudio);
        }

        // Set correct instrument to -1 to stop audio playing
        correctInstrument = -1;
    }



    public void Clear() {

    	// Set all audio clips to null
    	foreach(var aus in audioSources)
        {
            aus.clip = null;
        }

        // Destory all instruments in the cache
        for(int i = 0; i < cache.Length; i++)
        {
            Destroy(cache[i]);
            cache[i] = null;
        }

    }



    public void spawnRandomInfinite()
    {

        // If number of instruments remaining is less than three, "reset" list by referencing spawnees copy
        if (spawnees.Count < numSpawnPositions)
        {
            spawnees = new List<GameObject>(spawneesCopy);
        }

        // Shuffle the instruments.
        ShuffleInstruments();

        // Turn buttons on for selection
        ButtonControl("ON");


        // Spawn the first three instruments in the shuffled spawnees list and remove from list
        for (int i = 0; i < numSpawnPositions; i++)
        {
            GameObject g = Instantiate(spawnees[0], spawnPositions[i].position, spawnPositions[i].rotation) as GameObject;
            cache[i] = g;
            spawnees.RemoveAt(0);
        }

        // Assign text to buttons, randomly select correct instrument and set audio for correct instrument
        SetButtonNames();
        SelectCorrectInstrument();
        SetAudioClips(cache[correctInstrument]);
    }



    private void SetButtonNames()
    {
    	// Set text for buttons as instrument names
        leftButton.text = GetNameWithoutClone(cache[0].name);
        middleButton.text = GetNameWithoutClone(cache[1].name);
        rightButton.text = GetNameWithoutClone(cache[2].name);
    }

    private string GetNameWithoutClone(string name)
    {
    	// Remove the word "clone" from instrument names
        return name.Split('(')[0];
    }

    private void SetAudioClips(GameObject obj)
    {
        Debug.Log(obj.name);

        // Set audio for instrument by locating instrument in hierarchy and assigning attached audio to each source
        AudioSource a = GameObject.Find(obj.name).GetComponent<AudioSource>();
        foreach(var audioSource in audioSources)
        {
            audioSource.clip = a.clip;
        }

        // Play each audio source
        audioSources[0].Play();
        audioSources[1].Play();
        audioSources[2].Play();
        audioSources[3].Play();
    }



    private void ShuffleInstruments()
    {
    	// Shuffle the instruments in the list; this is a simple but not truly random way to do this
        spawnees = spawnees.OrderBy(x => Random.value).ToList();
    }



    private void SelectCorrectInstrument()
    {
    	// Assign a random instrument between index 1 and 3 to be the correct instrument
        correctInstrument = (int)Random.Range(0, 3);
    }



    public void PauseBeforeSpawn(string method){
    	// if the input is "Clear", call the Clear method after 2 seconds
    	if (method == "Clear"){
    		Invoke("Clear", 2);
    	}

    	// If the input is "spawnRandomInfinite", call the spawnRandomFinite method after 2 seconds
    	else if (method == "spawnRandomInfinite"){
    		Invoke("spawnRandomInfinite", 2);
    	}
    }



    private void ButtonControl(string command){

    	// If input is "ON", enable buttons
    	if (command == "ON"){
    		Left.interactable = true;
        	Right.interactable = true;
        	Middle.interactable = true;
    	}

    	// If input is "OFF", disable buttons
    	else if (command == "OFF"){
    		Left.interactable = false;
        	Right.interactable = false;
        	Middle.interactable = false;
    	}
    }

}