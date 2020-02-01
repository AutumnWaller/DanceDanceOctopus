using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SongController : MonoBehaviour
{
    [SerializeField]public  SongType m_SongSelection;
    [SerializeField]public  List<Song> m_Songs;

    public List<GameObject> m_Spawners;

    private float m_CountDown = 0.0f;
    private int m_CurrentCountDownLimit;


    public enum SongType
    {
        NeverGonnaGiveYouUp
    }

    void Awake()
    {
        PlaySong();
    }

    private void Update()
    {
        m_CountDown -= Time.deltaTime;
        if(m_CountDown <= 0)
        {
            ResetTimer();
            System.Random rand = new System.Random();
            m_Spawners[rand.Next(0, m_Spawners.Count)].GetComponent<Spawner>().Spawn();
        }
    }

    private void ResetTimer()
    {
        m_CountDown = m_CurrentCountDownLimit;
    }

    private void PlaySong()
    {
        m_Songs[(int)m_SongSelection].enabled = true;
        m_CurrentCountDownLimit = m_Songs[(int)m_SongSelection].m_BeatInterval;
        ResetTimer();
        GetComponent<AudioSource>().clip = m_Songs[(int)m_SongSelection].m_Clip;
        GetComponent<AudioSource>().Play();
    }

    public void SwitchSongs(SongType song)
    {
        m_Songs[(int)m_SongSelection].enabled = false;
        m_Songs[(int)song].enabled = true;
        m_SongSelection = song;
        PlaySong();
    }
}
