using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject enemyFab;
    public int enemyCount;
    public int waveNumber = 1;
    private float spawnRange = 9.0f;

    public GameObject powerUpPrefab;
    // Start is called before the first frame update
    void Start()
    {
        SpawnEnemy(waveNumber);
        Instantiate(powerUpPrefab, GenSpawnPos(), powerUpPrefab.transform.rotation);

    }

    // Update is called once per frame
    void Update()
    {
        enemyCount = FindObjectsOfType<Enemy>().Length;
        if (enemyCount == 0)
        {
            waveNumber++;
            SpawnEnemy(waveNumber);
            Instantiate(powerUpPrefab, GenSpawnPos(), powerUpPrefab.transform.rotation);
        }
    }

    void SpawnEnemy(int enemiesToSpawn)
    {
        for (int i = 0; i < enemiesToSpawn; i++)
        {
            Instantiate(enemyFab, GenSpawnPos(), enemyFab.transform.rotation);  
        }
    }

    private Vector3 GenSpawnPos()
    {
        float spawnPosX = Random.Range(-spawnRange, spawnRange);
        float spawnPosZ = Random.Range(-spawnRange, spawnRange);
        Vector3 randomPos = new Vector3(spawnPosX, 0, spawnPosZ);
        return randomPos;
    }
}
