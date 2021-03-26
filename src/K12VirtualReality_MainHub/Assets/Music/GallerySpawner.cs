using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GallerySpawner : MonoBehaviour
{
    public List<GameObject> Spawnees;
    public Transform SpawnPosition;
    public List<AudioSource> audioSources;
    public List<TMPro.TextMeshProUGUI> instrumentDescriptions;
    public TMPro.TextMeshProUGUI Description;

    private GameObject _CachedObject;
    private int _CurrentIndex;
    private bool instrumentExists = false;
    


    // Start is called before the first frame update
    void Start()
    {
        _CurrentIndex = 0;
    }

    // Time remaining before the audio plays again.
    private float timeRemaining = 10.0f;
    public void PlaySound()
    {
                audioSources[0].Play();
                audioSources[1].Play();
                audioSources[2].Play();
                audioSources[3].Play();
    }

    public void Next()
    {
        if (_CurrentIndex == Spawnees.Count - 1) return;
        SpawnInstrumentAt(++_CurrentIndex);
    }

    public void Previous()
    {
        if (_CurrentIndex == 0) return;
        SpawnInstrumentAt(--_CurrentIndex);
    }

    public void SpawnInstrumentAt(int index)
    {
        Destroy(_CachedObject);
        _CachedObject = Instantiate(Spawnees[index], SpawnPosition.position, SpawnPosition.rotation) as GameObject;
        SetAudioClips(_CachedObject);
        Description.text = instrumentDescriptions[index].text;
        instrumentExists = true;
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
 
}
