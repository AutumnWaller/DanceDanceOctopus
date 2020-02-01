using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SongController : MonoBehaviour
{
    [SerializeField]public  SongType m_SongSelection;
    [SerializeField]public  List<Song> m_Songs;

    public enum SongType
    {
        NeverGonnaGiveYouUp
    }

    void Awake()
    {
        PlaySong();
    }

    private void PlaySong()
    {
        m_Songs[(int)m_SongSelection].enabled = true;
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
