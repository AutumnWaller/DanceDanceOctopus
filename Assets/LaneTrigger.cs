using UnityEngine;

public class LaneTrigger : MonoBehaviour
{
    [SerializeField] int LaneNo = 0;
    Ocotpus_Script OctoScript;
    private void Start()
    {
        OctoScript = FindObjectOfType<Ocotpus_Script>();
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Has debris: " + other.gameObject.name);
        OctoScript.DebrisLane(true, other.gameObject, LaneNo);
    }
}
