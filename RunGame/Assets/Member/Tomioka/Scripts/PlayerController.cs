using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private GameObject bomb;

    [SerializeField]
    private float normalSpeed = 2;
    private float dashSpeed;

    public int playerHP = 10;
    [SerializeField]
    Text text;


    Rigidbody2D rb2d;

    private bool playerCol = true;

    public float starTime = 3;

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
        PlayerGameOver();
        text.text = playerHP.ToString();
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
        if (playerHP >=0)
        {
            if (Input.GetKeyDown(KeyCode.Space) && rb2d.velocity.y == 0)
            {
                rb2d.AddForce(Vector2.up * 400);
            }
        }
    }

    private void PlayerGameOver()
    {
        if (playerHP <= 0)
        {
            playerHP = 0;
            normalSpeed = 0;
        }
    }

    public void OnCollisionEnter2D(Collision2D col)
    {
        switch (col.gameObject.tag)
        {
            //後でFinishのtagを変える
            //ここに攻撃判定があるものを追加していく
            case "Finish":
            case "wall":

                if (playerCol == true)
                {
                    playerCol = false;
                    playerHP -= 3;
                    Debug.Log("ダメージ");
                    Invoke("InvincibleTime", 3f);
                }
                break;

            default:
                //Debug.Log(col.gameObject.tag);
                break;
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
