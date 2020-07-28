using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneMove : MonoBehaviour
{
    Rigidbody2D _rigidbody;

    [SerializeField] private float moveSpeed = 2.0f;

    [SerializeField] private GameObject bullet;

    [SerializeField] private float bulletTime = 2.0f;

    [SerializeField] public float bulletspeed = 2.0f;

    float t;

    void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    void Move()
    {
        _rigidbody.velocity = new Vector2(-moveSpeed, _rigidbody.velocity.y);
    }
    void Attack()
    {
        if (t > bulletTime)
        {
            GameObject bullets = Instantiate(bullet) as GameObject;

            bullet.transform.position = this.transform.position;

            t = 0.0f;

        }
        else
        {
            t += Time.deltaTime;
            print(t);
        }
    }
    private void FixedUpdate()
    {
        //Move();
        Attack();
    }
    void Update()
    {

    }

}
