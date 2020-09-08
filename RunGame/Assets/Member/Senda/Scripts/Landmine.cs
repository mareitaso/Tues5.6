using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Landmine : MonoBehaviour
{
    GameObject player;
    PlayerController playercontroller;

    void Start()
    {
        player = GameObject.Find("Player");
        playercontroller = player.GetComponent<PlayerController>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            playercontroller.playerHP -= 3;
            Debug.Log("hit");
            //effect
            Destroy(this.gameObject);
        }
    }
}
