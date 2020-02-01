using UnityEngine;

public class DebrisScript : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.back * Time.deltaTime * 10);
    }
}
