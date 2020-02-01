using UnityEngine;

public class TentacleScript : MonoBehaviour
{
    [SerializeField] int limbNo =0;
    Ocotpus_Script OctoScript;
    public GameObject[] holes;
    public int rand;
    private void Start()
    {
        OctoScript = FindObjectOfType<Ocotpus_Script>();
    }


    //make debris a child of tentacle to move
    public void MoveDebris()
    {
        OctoScript.FixTransformDebris(limbNo);
    }

    public void DisableDebris()
    {
        rand = Random.Range(0, 10);
        holes[rand].SetActive(false);

        OctoScript.DisableDebris(limbNo);

    }
}
