using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeSpawner : MonoBehaviour
{
    public GameObject pipePrefab;

    public float spawnInterval;



    void Start()
    {
        InvokeRepeating("SpawnPipe", 0f, spawnInterval); // Spawn a pipe every 2 seconds
    }

    void SpawnPipe()
    {
        Instantiate(pipePrefab, new Vector3(15, 0, 0), Quaternion.identity);
    }
}
