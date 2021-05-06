using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GallerySpawner : MonoBehaviour
{

    // Assign list of instruments, spawn position, audio sources, list of text description, and text description spawn location in Unity
    public List<GameObject> Spawnees;
    public Transform SpawnPosition;
    public List<AudioSource> audioSources;
    public List<TMPro.TextMeshProUGUI> instrumentDescriptions;
    public TMPro.TextMeshProUGUI Description;

    // Reference to the current instrument and current index in list
    private GameObject _CachedObject;
    private int _CurrentIndex;
    


    // Start is called before the first frame update
    void Start()
    {
        // Default currentIndex = 0
        _CurrentIndex = 0;
    }

   
    public void PlaySound()
    {
        // Play audio from each source when button is pressed in Unity
        audioSources[0].Play();
        audioSources[1].Play();
        audioSources[2].Play();
        audioSources[3].Play();
    }

    public void Next()
    {
        // Move to next instrument foward in list when button is pressed
        if (_CurrentIndex == Spawnees.Count - 1) return;
        SpawnInstrumentAt(++_CurrentIndex);
    }

    public void Previous()
    {
        // Move to previous instrument backwards in list when button is pressed
        if (_CurrentIndex == 0) return;
        SpawnInstrumentAt(--_CurrentIndex);
    }

    public void SpawnInstrumentAt(int index)
    {
        // Destory previously spawned instrument, spawn next instrument, set audio, and set description text
        Destroy(_CachedObject);
        _CachedObject = Instantiate(Spawnees[index], SpawnPosition.position, SpawnPosition.rotation) as GameObject;
        SetAudioClips(_CachedObject);
        Description.text = instrumentDescriptions[index].text;

    }

    private void SetAudioClips(GameObject obj)
    {
        // Set audio by locating the instrument in hierarchy and assigning clip attached to instrument to all sources
        Debug.Log(obj.name);
        AudioSource a = GameObject.Find(obj.name).GetComponent<AudioSource>();
        foreach(var auso in audioSources)
        {
            auso.clip = a.clip;
        }
    }
 
}
