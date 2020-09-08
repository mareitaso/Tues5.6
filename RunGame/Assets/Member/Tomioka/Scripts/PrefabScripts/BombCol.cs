using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombCol : MonoBehaviour
{
    [SerializeField]
    private PlayerController player;

    //public void OnTriggerEnter2D(Collider2D col)
    //{
    //    Debug.Log("ボム判定にあたった");

    //    if (col.gameObject.tag == "Player")
    //    {
    //        Debug.Log("ダメージ");
    //        player.jumpCom = false;
    //        player.playerHP -= 3;
    //    }
    //}

    //public void OnCollisionExit2D(Collision2D col)
    //{
    //    player.jumpCom = false;
    //} void OnTriggerEnter2D(Collider2D other)

    private void Start()
    {
        Destroy(this.gameObject, 3f);
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("OnTriggerEnter2D: " + other.gameObject.name);
    }

    void OnTriggerStay2D(Collider2D other)
    {
        Debug.Log("OnTriggerStay2D: " + other.gameObject.name);
    }

    void OnTriggerExit2D(Collider2D other)
    {
        Debug.Log("OnTriggerExit2D: " + other.gameObject.name);
    }



    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("OnCollisionEnter2D: " + collision.gameObject.name);
    }

    void OnCollisionStay2D(Collision2D collision)
    {
        Debug.Log("OnCollisionStay2D: " + collision.gameObject.name);
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        Debug.Log("OnCollisionExit2D: " + collision.gameObject.name);
    }
}