using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float speed = 1f;

    Rigidbody2D rb2d;

    // Use this for initialization
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }



    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb2d.AddForce(new Vector3(speed, 0, 0));
        }

        //transform.Translate(+0.1f, 0, 0);
        Jump();
    }

    private void Sliding()
    {

    }

    private void Jump()
    {
        if (Input.GetKeyDown("space"))
        {
            rb2d.AddForce(Vector2.up * speed);
        }
    }

}
