using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnwater : MonoBehaviour
{
    public GameObject water;
    public bool check;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (check)
        {
            if (this.gameObject.activeInHierarchy == false)
            {
                Instantiate(water, water.transform.position, Quaternion.identity);
                check = false;
            }
        }
    }
}
