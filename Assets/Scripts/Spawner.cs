using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // list of objects
    List<GameObject> listOfObj = new List<GameObject>();

    // Instance of pools
    PoolManager poolManager;

    // Will set each generated object to the initial starting postion of the Spawner object
    Vector3 currentPostion;

    // This will be matched up with Time.time
    private float nextSpawnTime;

    // The wood to be spawned
    [SerializeField]
    private GameObject currentObj;

    // How long you wanna delay each object being spawned
    [SerializeField]
    private float spawnDelay = 10f;

    // Update is called once per frame
    private void Update()
    {
        // pretty self explanatory
        if(ShouldSpawn())
        {
            Spawn();
        }
    }

    private void Awake()
    {
        currentPostion = transform.position;
        // Make a pool of how many objects you want
        PoolManager.CreatePool(currentObj, 30, ref listOfObj);
    }

    private bool ShouldSpawn()
    {
        return Time.time >= nextSpawnTime;
    }

    private void Spawn()
    {
        nextSpawnTime = Time.time + spawnDelay;
        GameObject setWoodPostion = PoolManager.GetObjectFromPool(listOfObj);
        setWoodPostion.transform.position = currentPostion;
        setWoodPostion.SetActive(true);
    }
}
