using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemys : MonoBehaviour
{public  GameObject[ ] TreePrefabs;
 private float spawnRangeX = 100;
 private float spawnPosZ = -100;
 private float startDelay = 0.5f;
 private float spawnInterval = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemy",startDelay,spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnEnemy()
     {
         Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX,spawnRangeX),0, spawnPosZ);
         int TreeIndex = Random.Range(0,  TreePrefabs.Length);
         Instantiate( TreePrefabs[TreeIndex],spawnPos,
           TreePrefabs[TreeIndex].transform.rotation);
     }
}
