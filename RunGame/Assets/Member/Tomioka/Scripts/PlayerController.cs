using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    

    [SerializeField]
    private float speed = 400;

    Rigidbody2D rb2d;

    // Use this for initialization
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }



    void Update()
    {
        PlayerMove();
        
        Jump();
    }

    private void PlayerMove()
    {
        speed = 2;
        rb2d.velocity = new Vector2(speed, rb2d.velocity.y);
    }


    private void Sliding()
    {

    }

    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb2d.AddForce(Vector2.up * 400);
            Debug.Log(speed);
        }
    }

}
