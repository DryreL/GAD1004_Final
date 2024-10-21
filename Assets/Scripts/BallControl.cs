using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{

    Rigidbody2D rb2d;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        Invoke("GoBall", 2f);
    }

    // Update is called once per frame
    void Update()
    {
    }

    void GoBall()
    {
        float rand = UnityEngine.Random.Range(0, 2);
        if (rand < 1)
        {
            rb2d.AddForce(new Vector2(200, -105));
        }
        else
        {
            rb2d.AddForce(new Vector2(-200, -105));
        }
    }

    void ResetBall()
    {
        StartCoroutine(Invisible());
        rb2d.linearVelocity = Vector2.zero;
        transform.position = Vector2.zero;
        Invoke("GoBall", 2f);

    }

    private IEnumerator Invisible()
    {
        GetComponent<SpriteRenderer>().enabled = false;
        yield return new WaitForSeconds(2);
        GetComponent<SpriteRenderer>().enabled = true;
    }

    void RestartGame()
    {
        ResetBall();

    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "LeftRacket" || coll.gameObject.tag == "RightRacket")
        {
            StartCoroutine(Invisible());
            Vector2 vel;
            vel.x = rb2d.linearVelocity.x;
            vel.y = (rb2d.linearVelocity.y / 2) + (coll.collider.attachedRigidbody.linearVelocity.y / 3);
            rb2d.linearVelocity = vel;
            GameManager.armut.PlayThis(0);
        }

        if (coll.gameObject.tag == "LeftWall" || coll.gameObject.tag == "RightWall")
        {
            //TODO add your Destroy code here-destroy the ball
            GameManager.armut.Score(coll.gameObject.tag);
            GameManager.armut.PlayThis(2);
            RestartGame();
        }

    }
}
