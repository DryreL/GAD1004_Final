using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movecon : MonoBehaviour

{

    Rigidbody2D rb2d;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        //rb2d.velocity = new Vector2(0, 0);
        //rb.angularVelocity = new Vector3(4, 0, 0);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.name == "buffer")
        {
            rb2d.linearVelocity = new Vector2(0, 0);
        }

        if (other.name  == "teleshot")
        {
            GetComponent<Rigidbody2D>().linearVelocity = new Vector2(2, 0);

        }

    }
}
