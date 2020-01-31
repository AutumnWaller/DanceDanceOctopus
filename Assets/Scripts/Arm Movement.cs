using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmMovement : MonoBehaviour
{ 
    public GameObject arm; 

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            arm.transform.Rotate(90.0f, 0.0f, 0.0f, Space.Self);

        }
    }
}
