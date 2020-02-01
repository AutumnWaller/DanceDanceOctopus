using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnwater : MonoBehaviour
{
    public GameObject water;
    public bool check = true;
    
    // Start is called before the first frame update
    void Start()
    {
        check = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (check)
        {
            if (this.gameObject.activeInHierarchy == true)
            {
                print("yes");
                Instantiate(water, water.transform.position, Quaternion.identity);
                check = false;
            }
        }
    }
}
