using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class SpectrumGenerator : MonoBehaviour
{
    //Size of the spectrum
    [SerializeField] private int m_SpectrumSize;

    //Point in spectrum being read
    [SerializeField] private int m_SpectrumPoint;

    public static float spectrumValue;

    private float[] m_SpectrumData;

    private void Start()
    {
        m_SpectrumData = new float[m_SpectrumSize];
    }

    void Update()
    {
        AudioListener.GetSpectrumData(m_SpectrumData, 0, FFTWindow.BlackmanHarris);
        spectrumValue = (m_SpectrumData[m_SpectrumPoint] * 100);
    }
}

