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
        spectrumValue = 0;
        for (int i = 8; i < (m_SpectrumSize / 8) + 8; ++i)
        {
            spectrumValue += m_SpectrumData[i];  
        }
        spectrumValue /= m_SpectrumSize / 8;
        spectrumValue *= 100;
        for (int i = 1; i < m_SpectrumData.Length - 1; i++)
        {
            Debug.DrawLine(new Vector3(i - 1, m_SpectrumData[i] + 10, 0), new Vector3(i, m_SpectrumData[i + 1] + 10, 0), Color.red);
            Debug.DrawLine(new Vector3(i - 1, Mathf.Log(m_SpectrumData[i - 1]) + 10, 2), new Vector3(i, Mathf.Log(m_SpectrumData[i]) + 10, 2), Color.cyan);
            Debug.DrawLine(new Vector3(Mathf.Log(i - 1), m_SpectrumData[i - 1] - 10, 1), new Vector3(Mathf.Log(i), m_SpectrumData[i] - 10, 1), Color.green);
            Debug.DrawLine(new Vector3(Mathf.Log(i - 1), Mathf.Log(m_SpectrumData[i - 1]), 3), new Vector3(Mathf.Log(i), Mathf.Log(m_SpectrumData[i]), 3), Color.blue);
        }
        //spectrumValue = (m_SpectrumData[m_SpectrumPoint] * 100);
        //Debug.Log(spectrumValue);
    }
}

