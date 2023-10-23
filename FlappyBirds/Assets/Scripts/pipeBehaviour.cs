using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeBehaviiour : MonoBehaviour
{
    public float pipeSpeed;


    void Start()
    {

    }


    void Update()
    {
        gameObject.transform.position += Vector3.left * (pipeSpeed * Time.deltaTime);


        if (gameObject.transform.position.x < -15)
        {
            Destroy(gameObject);
        }
    }
}
