using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GallerySpawner : MonoBehaviour
{
    public List<GameObject> Spawnees;
    public Transform SpawnPosition;
    private GameObject _CachedObject;
    private int _CurrentIndex;

    // Start is called before the first frame update
    void Start()
    {
        _CurrentIndex = 0;
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

    private void SpawnInstrumentAt(int index)
    {
        Destroy(_CachedObject);
        _CachedObject = Instantiate(Spawnees[index], SpawnPosition.position, SpawnPosition.rotation) as GameObject;
    }

/*
    // Update is called once per frame
    void Update()
    {
        
    }*/
}
