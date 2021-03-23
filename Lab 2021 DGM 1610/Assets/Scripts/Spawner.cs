using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;
using System;
public class Spawner : MonoBehaviour
{
    public GameObject[] objPrefabsss;
    public float startDelay, repeatRate;
   // private Jump jumpscript;

    private Vector3 spawnPos = new Vector3(25, 0, 0);
    // Start is called before the first frame update
   /* void Start()
    {
        int _randomSpawnInt = Random.Range(3, 10);
        InvokeRepeating(nameof(SpawnRandomObj), startDelay, repeatRate);
        jumpscript = GameObject.Find("player").GetComponent<Jump>();
    }*/

    /*private void Update()
    {
        if (objPrefabsss.transform.position.x < -10f)
        {
            Destroy(gameObject);
        }
    }*/
    //this doesnt work because it cannot track an item that doesnt exist yet
    

    // Update is called once per frame
   /* void SpawnRandomObj ()
    {
        if (jumpscript.gameOver == false)
        {
            int objLibrary = Random.Range(0, objPrefabsss.Length);
            // Generate random ball index and random spawn position
        

            // instantiate ball at random spawn location
            Instantiate(objPrefabsss[objLibrary], spawnPos, objPrefabsss[objLibrary].transform.rotation);
        }
    }*/
}
