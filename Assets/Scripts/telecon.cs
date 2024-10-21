using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class telecon : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.name = "teleshot";
        GetComponent<Rigidbody2D>().linearVelocity = new Vector2(2, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
