using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{


    [SerializeField]
    private float speed = 2;

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
        rb2d.velocity = new Vector2(speed, rb2d.velocity.y);
    }


    private void Sliding()
    {

    }

    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && rb2d.velocity.y == 0)
        {
            rb2d.AddForce(Vector2.up * 400);
            Debug.Log(speed);
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        //後でtagを変える
        if (col.tag == "Finish")
        {
            Debug.Log("ダメージ");
        }
    }

}
