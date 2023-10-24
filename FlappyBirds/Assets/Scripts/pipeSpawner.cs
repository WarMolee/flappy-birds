using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeSpawner : MonoBehaviour
{
    public GameObject pipePrefab;
    public GameObject pointPrefab;

    public float pipeSpawnInterval;

    public float pipeXSpawn;
    public float pipeYSpawnLow;
    public float pipeYSpawnHigh;

    public GameObject bushPrefab1;
    public GameObject bushPrefab2;

    public float bushSpawnInterval;


    public GameObject housePrefab1;
    public GameObject housePrefab2;
    public GameObject housePrefab3;

    public float houseSpawnInterval;

    public GameObject hill1;
    public GameObject hill2;

    public float hillSpawnInterval;

    void Start()
    {
        InvokeRepeating("SpawnPipe", 0f, pipeSpawnInterval);
        InvokeRepeating("spawnBush", 0f, bushSpawnInterval);
        //InvokeRepeating("SpawnHouse", 0f, houseSpawnInterval);
        InvokeRepeating("SpawnHill", 0f, hillSpawnInterval);
    }

    void SpawnPipe()
    {
        float pipeYSpawn = UnityEngine.Random.Range(pipeYSpawnLow, pipeYSpawnHigh);
        Instantiate(pointPrefab, new Vector3(pipeXSpawn, pipeYSpawn + 4, 0), Quaternion.identity);
        Instantiate(pipePrefab, new Vector3(pipeXSpawn, pipeYSpawn, 0), Quaternion.identity);
    }

    void spawnBush()
    {
        int bushRand = UnityEngine.Random.Range(0, 2);
        int bushRandspawn = UnityEngine.Random.Range(15, 18);

        if (bushRand == 1)
        {
            Instantiate(bushPrefab1, new Vector3(bushRandspawn, -5, -5), Quaternion.identity);
        }
        else
        {
            Instantiate(bushPrefab2, new Vector3(bushRandspawn, -5, -5), Quaternion.identity);
        }



    }
    void SpawnHouse()
    {
        int houseRand = UnityEngine.Random.Range(0, 3);


        if (houseRand == 1)
        {
            Instantiate(housePrefab1, new Vector3(15, -4, 4), Quaternion.identity);
        }
        else if (houseRand == 2)
        {
            Instantiate(housePrefab2, new Vector3(15, -3, 4), Quaternion.identity);
        }
        else
        {
            Instantiate(housePrefab3, new Vector3(15, -4, 4), Quaternion.identity);
        }

    }

    void SpawnHill()
    {
        int hillRand = UnityEngine.Random.Range(0, 2);
        int hillRandspawn = UnityEngine.Random.Range(15, 18);
        int hillRandY = UnityEngine.Random.Range(-9, -5);

        if (hillRand == 1)
        {
            Instantiate(hill1, new Vector3(hillRandspawn, hillRandY, 5), Quaternion.identity);
        }
        else
        {
            Instantiate(hill2, new Vector3(hillRandspawn, hillRandY, 4), Quaternion.identity);
        }
    }

}
