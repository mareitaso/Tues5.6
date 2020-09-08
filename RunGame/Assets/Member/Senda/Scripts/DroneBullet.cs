using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneBullet : DroneMove
{
    [SerializeField]
    PlayerController player;

    [SerializeField]
    private GameObject bombEffect;

    void Start()
    {
        Destroy(this.gameObject, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 force;

        force = this.gameObject.transform.up * bulletspeed;

        this.GetComponent<Rigidbody2D>().AddForce(force);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            player.PlayerDamage();
            Debug.Log("hit");
            Instantiate(bombEffect, new Vector2(this.transform.position.x, this.transform.position.y), Quaternion.identity);
            Destroy(this.gameObject);
        }
        else if (collision.CompareTag("Stage"))
        {
            //effect
        }

    }

}
