using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bushSpawner : MonoBehaviour
{
    public GameObject bushPrefab1;
    public GameObject bushPrefab2;

    public float spawnInterval;



    void Start()
    {
        InvokeRepeating("spawnBush", 0f, spawnInterval); // Spawn a pipe every 2 seconds
    }

    void spawnBush()
    {
        int bushRand = UnityEngine.Random.Range(0, 2);
        int bushRandspawn = UnityEngine.Random.Range(15, 18);

        if (bushRand == 1)
        {
            Instantiate(bushPrefab1, new Vector3(bushRandspawn, -5, -5), Quaternion.identity);
        }
        else{
            Instantiate(bushPrefab2, new Vector3(bushRandspawn, -5, -5), Quaternion.identity);
        }



    }
}