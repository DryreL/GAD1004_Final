using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacketMovement : MonoBehaviour
{

    public float Speed = 30f;
    public string axis;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float v = Input.GetAxisRaw(axis);
        GetComponent<Rigidbody2D>().linearVelocity = new Vector2(0, v) * Speed;

    }
}
