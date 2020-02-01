using System.Collections.Generic;
using UnityEngine;

//We're all going to die, what does it matter
public class Ocotpus_Script : MonoBehaviour
{
    [SerializeField]
    GameObject[] limbsGO;
    Animator[] limbs;
    [SerializeField]
    KeyCode Tentacle_01, Tentacle_02,Tentacle_03,Tentacle_04,Tentacle_05,Tentacle_06;
    [SerializeField]
    bool[] canGrab;


    void Start()
    {
        for (int i = 0; i < limbsGO.Length; i++)
        {
            limbs[i] = limbsGO[i].GetComponent<Animator>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(Tentacle_01))
        {
            if(canGrab[0]==true)
            {
                limbs[0].SetTrigger("Grab");
            }
        }

    }
}
