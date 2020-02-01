using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionboat : MonoBehaviour
{
    public GameObject shark;
    public GameObject decals;
    public GameObject decals2;
    int rand;
    // Start is called before the first frame update
    void Start()
    {
        decals2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision other)
    {
        print(other);
        rand = Random.Range(0, 2);
        if (rand == 1)
        {
            decals.SetActive(true);
        }
        else
        {
            decals2.SetActive(true);
        }
    }
}
