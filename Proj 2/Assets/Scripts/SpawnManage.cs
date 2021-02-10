using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnManage : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnX = 19, spawnZ = 30, spawnInterval = 1.3f, spawnTime = 2;

    private void Start()
    {
        InvokeRepeating(nameof(SpawnRate), spawnTime,spawnInterval);
    }
    
    void SpawnRate()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnX, spawnX), 0, spawnZ);
            
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}
