using UnityEngine;

public class TentacleScript : MonoBehaviour
{
    [SerializeField] int limbNo =0;
    Ocotpus_Script OctoScript;
    public GameObject[] holes;
    public int rand;
    public spawnwater water; 
    private void Start()
    {
        water = GetComponent<spawnwater>();
        OctoScript = FindObjectOfType<Ocotpus_Script>();
    }


    //make debris a child of tentacle to move
    public void MoveDebris()
    {
        OctoScript.FixTransformDebris(limbNo);
    }

    public void DisableDebris()
    {
        water.check = true;
        rand = Random.Range(0, 9);
        holes[rand].SetActive(false);
       
        OctoScript.DisableDebris(limbNo);

    }
}
