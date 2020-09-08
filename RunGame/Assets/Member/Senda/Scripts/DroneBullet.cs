using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneBullet : DroneMove
{
    GameObject player;
    PlayerController playercontroller;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        playercontroller = player.GetComponent<PlayerController>();
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
            playercontroller.playerHP -= 3;
            Debug.Log("hit");
            Destroy(this.gameObject);
        }else if (collision.CompareTag("press"))
        {
            //effect
        }

    }
}
