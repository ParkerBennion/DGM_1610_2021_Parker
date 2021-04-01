using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject enemyFab;

    private float spawnRange = 9.0f;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < UPPER; i++)
        {
            
        }
        Instantiate(enemyFab, GenSpawnPos(), enemyFab.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private Vector3 GenSpawnPos()
    {
        float spawnPosX = Random.Range(-spawnRange, spawnRange);
        float spawnPosZ = Random.Range(-spawnRange, spawnRange);
        Vector3 randomPos = new Vector3(spawnPosX, 0, spawnPosZ);
        return randomPos;
    }
}
