using UnityEngine;

public class TentacleScript : MonoBehaviour
{
    [SerializeField] int limbNo =0;
    Ocotpus_Script OctoScript;
    public GameObject hole;
    private void Start()
    {
        //water = hole.GetComponent<spawnwater>();
        OctoScript = FindObjectOfType<Ocotpus_Script>();
    }


    //make debris a child of tentacle to move
    public void MoveDebris()
    {
        OctoScript.FixTransformDebris(limbNo);
    }

    public void DisableDebris()
    {
        OctoScript.DisableDebris(limbNo);
        if(hole.activeSelf)
        {
            hole.SetActive(false);
        }
    }
}
