using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shark : MonoBehaviour
{
    Rigidbody rb;
    public bool hit;
    public float timeLeft = 3f;
    public bool news;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        hit = false;
        timeLeft = 3f;
    }

    // Update is called once per frame
    void Update()
    {
          
        if (news)
        {
            timeLeft -= Time.deltaTime;
            if (timeLeft < 0)
            {
                hit = true;
                timeLeft = 3f;
            }
        }

        print(hit);
        rb.velocity = transform.forward * 10;
        if (hit)
        {
            rb.velocity += transform.right * 1;
            rb.velocity += transform.up * -10;
            rb.velocity += transform.forward * -10;

        }
    }
    void OnCollisionEnter(Collision other)
    {
        
        news = true;
        for (int i = 0; i > 50; i++)
        {
        
            this.transform.Rotate(transform.rotation.x -0.2f, transform.rotation.y + 0.2f, transform.rotation.z);
          
        }

    }
    private IEnumerator coroutine()
    {
        yield return new WaitForSeconds(3);
        Destroy(this.gameObject);

}

}
