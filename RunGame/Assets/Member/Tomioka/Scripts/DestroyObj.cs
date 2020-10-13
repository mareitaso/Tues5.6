using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObj : MonoBehaviour
{
    [SerializeField]
    private PlayerController player;

    private Rigidbody2D rb2d;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        DestroyerMove();
    }
    private void DestroyerMove()
    {
        if (Input.GetKey(KeyCode.D))
        { 
            rb2d.velocity = new Vector2(player.dashSpeed, rb2d.velocity.y);
        }
        else
        {
            rb2d.velocity = new Vector2(player.normalSpeed, rb2d.velocity.y);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(other.gameObject);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        Destroy(col.gameObject);
    }

}
