using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] objPrefabsss;
    public float startDelay, repeatRate;

    private Vector3 spawnPos = new Vector3(25, 0, 0);
    // Start is called before the first frame update
    void Start()
    {
        int _randomSpawnInt = Random.Range(3, 10);
        InvokeRepeating(nameof(SpawnRandomObj), startDelay, repeatRate);
    }

    /*private void Update()
    {
        if (objPrefabsss.transform.position.x < -10f)
        {
            Destroy(gameObject);
        }
    }*/
    //this doesnt work because it cannot track an item that doesnt exist yet
    

    // Update is called once per frame
    void SpawnRandomObj ()
    {
        int ballLibrary = Random.Range(0, objPrefabsss.Length);
        // Generate random ball index and random spawn position
        

        // instantiate ball at random spawn location
        Instantiate(objPrefabsss[ballLibrary], spawnPos, objPrefabsss[ballLibrary].transform.rotation);
    }
}
