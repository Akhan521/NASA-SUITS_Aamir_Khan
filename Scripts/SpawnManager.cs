using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Animal prefabs:
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 20;
    private float spawnPosZ = 20;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        //We repeatedly call our SpawnRandomAnimal method every few seconds.
        //We initially delay it for a few seconds before we start calling it.
        InvokeRepeating("SpawnRandomAnimal",startDelay,spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    //Spawns a random animal.
    void SpawnRandomAnimal(){
        //Choosing a random animal prefab to spawn.
        int animalIndex = Random.Range(0,animalPrefabs.Length);
        //Choosing a random position to spawn our animal at.
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX,spawnRangeX),0,spawnPosZ);
        //We instantiate a prefab from our array and place it at the top of our screen.
        //We leave its rotation alone.
        Instantiate(animalPrefabs[animalIndex], spawnPos,
        animalPrefabs[animalIndex].transform.rotation);
    }
}
