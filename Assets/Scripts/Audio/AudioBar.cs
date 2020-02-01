using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioBar : AudioSyncer
{
    [SerializeField]private Vector3 m_restScale;
    [SerializeField]private Vector3 m_beatScale;
    [SerializeField] private float m_restTimer;
    [SerializeField] private float m_beatTimer;


    private IEnumerator BeatScale(Vector3 _target)
    {
        Vector3 initialScale = transform.localScale;
        float timer = 0;

        while (transform.localScale != _target)
        {
            transform.localScale = Vector3.Lerp(initialScale, _target, timer / m_beatTimer);
            timer += Time.deltaTime;

            yield return null;
        }

        m_Beat = false;
    }
    //When the spectrum goes over the threshold
    protected override void TriggerBeat()
    {
        base.TriggerBeat();

        StopCoroutine("BeatScale");
        StartCoroutine("BeatScale", m_beatScale);
    }

    protected override void UpdateBeat()
    {
        base.UpdateBeat();
        if (m_Beat)
        {
            return;
        }
        transform.localScale = Vector3.Lerp(transform.localScale, m_restScale, m_restTimer * Time.deltaTime);
    }
}
