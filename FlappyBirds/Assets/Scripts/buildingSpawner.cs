using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buildingSpawner : MonoBehaviour
{
    public GameObject housePrefab1;
    public GameObject housePrefab2;
    public GameObject housePrefab3;

    public float spawnInterval;



    void Start()
    {
        InvokeRepeating("SpawnHouse", 0f, spawnInterval); // Spawn a pipe every 2 seconds
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
}
