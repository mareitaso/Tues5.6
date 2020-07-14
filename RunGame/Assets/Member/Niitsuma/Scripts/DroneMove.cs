using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneMove : MonoBehaviour
{
    Rigidbody2D _rigidbody;
    [SerializeField] private float moveSpeed = 2.0f;
    [SerializeField] private GameObject bullet;
    [SerializeField] private float bulletTime = 2.0f;

    float t;

    void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    void Move()
    {
        _rigidbody.velocity = new Vector2(-moveSpeed, _rigidbody.velocity.y);
    }
    void Beam()
    {
        if(t > bulletTime)
        {
            bullet.SetActive(true);
            bullet.transform.position = this.transform.position;

        }
        else
        {
            t += Time.deltaTime;

        }
    }
    private void FixedUpdate()
    {
        Move();
    }
    void Update()
    {
        
    }
}
