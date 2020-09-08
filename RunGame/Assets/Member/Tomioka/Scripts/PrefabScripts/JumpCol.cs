using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpCol : MonoBehaviour
{
    [SerializeField]
    private PlayerController player;

    //public void OnCollisionEnter2D(Collision2D col)
    //{
    //    Debug.Log("ジャンプ判定にあたった");
    //    if (player.jumpCom == true && Input.GetKey(KeyCode.Space))
    //    {
    //        player.Jump();
    //    }
    //}
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
