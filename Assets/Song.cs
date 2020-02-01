using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Song : MonoBehaviour
{
    public float m_BeatInterval;
    [SerializeField] public AudioClip m_Clip;

    public string m_SongName;
    public string m_SongLength;

    private void Start()
    {
        m_SongName = m_Clip.name;
        m_SongLength = m_Clip.length.ToString();
    }
}
