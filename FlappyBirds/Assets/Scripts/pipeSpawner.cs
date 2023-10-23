using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeSpawner : MonoBehaviour
{
    public GameObject pipePrefab;
    public GameObject pointPrefab;

    public float spawnInterval;

    public float pipeXSpawn;
    public float pipeYSpawnLow;
    public float pipeYSpawnHigh;


    void Start()
    {
        InvokeRepeating("Spawn", 0f, spawnInterval); // Spawn a pipe every 2 seconds
    }

    void Spawn()
    {
        float pipeYSpawn = UnityEngine.Random.Range(pipeYSpawnLow, pipeYSpawnHigh);
        Instantiate(pointPrefab, new Vector3(pipeXSpawn, (pipeYSpawn + 4), 0), Quaternion.identity);
        Instantiate(pipePrefab, new Vector3(pipeXSpawn, pipeYSpawn, 0), Quaternion.identity);
    }
}
