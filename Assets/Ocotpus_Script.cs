using System.Collections.Generic;
using UnityEngine;

//We're all going to die, what does it matter
public class Ocotpus_Script : MonoBehaviour
{
    [SerializeField]
    GameObject[] limbsGO;
    [SerializeField]
    GameObject[] limbsTip;
    [SerializeField]
    Animator[] limbs = { };
    [SerializeField]
    KeyCode Tentacle_01, Tentacle_02,Tentacle_03,Tentacle_04,Tentacle_05,Tentacle_06;
    [SerializeField]
    bool[] canGrab;
    [SerializeField]
    GameObject[] debris;


    void Start()
    {
        //for (int i = 0; i < limbsGO.Length; i++)
        //{
        //    limbs[i] = limbsGO[i].GetComponent<Animator>();
        //}
        limbs[0] = limbsGO[0].GetComponent<Animator>();
                limbs[1] = limbsGO[1].GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(Tentacle_01))
        {
            if(canGrab[0]==true)
            {
                limbs[0].SetBool("Grab", true);
            }
        }

        if(Input.GetKeyDown(Tentacle_02))
        {
            if(canGrab[1]==true)
            {
                limbs[1].SetBool("Grab", true);
            }
        }

    }

    public void DebrisLane(bool hasDebris, GameObject debrisGO, int LaneNo)
    {
        if(canGrab[LaneNo]==false)
        {
        canGrab[LaneNo] = hasDebris;
        debris[LaneNo] = debrisGO;
        Debug.Log("Can grab");
        }
    }


    public void FixTransformDebris(int debrisNo)
    {
        debris[debrisNo].transform.parent = limbsTip[debrisNo].transform;
        debris[debrisNo].transform.position = limbsTip[debrisNo].transform.position;
    }

    public void DisableDebris(int debrisNo)
    {
        limbs[debrisNo].SetBool("Grab", false);

        debris[debrisNo].SetActive(false);
        debris[debrisNo] = null;
        canGrab[debrisNo] = false;
    }
}
