using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private GameObject bomb;

    [SerializeField]
    private float normalSpeed = 2;
    private float dashSpeed;

    Rigidbody2D rb2d;

    private bool playerCol =true;

    // Use this for initialization
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }



    void Update()
    {
        PlayerMove();
        UseItem();
        Jump();
    }

    private void PlayerMove()
    {
        if (Input.GetKey(KeyCode.D))
        {
            dashSpeed = normalSpeed * 3;
            rb2d.velocity = new Vector2(dashSpeed, rb2d.velocity.y);
        }
        else
        {
            rb2d.velocity = new Vector2(normalSpeed, rb2d.velocity.y);
        }
    }


    private void Sliding()
    {

    }

    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && rb2d.velocity.y == 0)
        {
            rb2d.AddForce(Vector2.up * 400);
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (playerCol == true)
        {
            playerCol = false;
            //後でtagを変える
            if (col.tag == "Finish")
            {
                Debug.Log("ダメージ");
                Invoke("InvincibleTime", 3f);
            }
        }
    }

    private void UseItem()
    {
        //爆弾テスト
        if (Input.GetKeyDown(KeyCode.B))
        {
            Instantiate(bomb, new Vector2(this.transform.position.x + 1f, this.transform.position.y), Quaternion.identity);
            bomb.GetComponent<BombTest>().UseBomb(new Vector2(1000000, 1000000));
        }

        //花火
        if (Input.GetKeyDown(KeyCode.N))
        {
           
        }

    }

    private void InvincibleTime()
    {
        playerCol = true;
    }

    public void SpeedUp()
    {
        normalSpeed += 1;
    }
}
