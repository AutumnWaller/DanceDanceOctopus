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
        rb.velocity = transform.forward * 50;
        if (hit)
        {
            rb.velocity += transform.right * -15;
            rb.velocity += transform.up * -50;
            rb.velocity += transform.forward * 15;
            StartCoroutine(coroutine());

        }
    }
    void OnCollisionEnter(Collision other)
    {
        
        news = true;
        for (int i = 0; i > 50; i++)
        {
        
            this.transform.Rotate(transform.rotation.x -1f, transform.rotation.y + 1f, transform.rotation.z);
          
        }

    }
    private IEnumerator coroutine()
    {
        yield return new WaitForSeconds(1);
        Destroy(this.gameObject);

}

}
