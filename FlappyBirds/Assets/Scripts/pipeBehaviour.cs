using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeBehaviiour : MonoBehaviour
{
    public float pipeSpeed;
    public float pipeXSpawn;
    public float pipeYSpawnLow;
    public float pipeYSpawnHigh;
    

    void Start()
    {
        float pipeYSpawn = UnityEngine.Random.Range(pipeYSpawnLow, pipeYSpawnHigh);

        gameObject.transform.position = new Vector3(pipeXSpawn, pipeYSpawn, 0);
        Debug.Log("Pipe Spawned");
    }


    void Update()
    {
        gameObject.transform.position += Vector3.left * (pipeSpeed * Time.deltaTime);


        if(gameObject.transform.position.x < -pipeXSpawn)
        {
            Destroy(gameObject);
        }
    }
}
