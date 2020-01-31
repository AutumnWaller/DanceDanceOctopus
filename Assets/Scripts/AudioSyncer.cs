using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSyncer : MonoBehaviour
{
    private bool m_Beat = false;

    [SerializeField]private float m_Threshold;
    [SerializeField]private float m_CountDownTime;

    private float m_Timer;

    //When the spectrum goes over the threshold
    private void TriggerBeat()
    {
        m_Beat = true;
        m_Timer = m_CountDownTime;
        //prefab.SetActive(true);
    }

    private void CountDown()
    {
        m_Timer -= Time.deltaTime;
    }

    // Update is called once per frame
    private void Update()
    {
        if(m_Beat)
        {
            m_Beat = false;
           // prefab.SetActive(false);
        }
        if (m_Timer <= 0 && SpectrumGenerator.spectrumValue > m_Threshold)
        {
            TriggerBeat();
        }
        if(m_Timer > 0)
        {
            CountDown();
        }
    }
}
