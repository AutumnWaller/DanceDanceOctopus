using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnshark : MonoBehaviour
{
    public GameObject shark;
    public GameObject[] spawnpointsleft;
    public GameObject[] spawnpointsright;
    public int rand;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        rand = (Random.Range(0, 10));
        Instantiate(shark, (spawnpointsleft[rand].transform.position), Quaternion.identity);
    }
}
