using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallTest : MonoBehaviour
{
    [SerializeField]
    private PlayerController player;

    private Collider2D col2d;

    private void Start()
    {
        col2d = GetComponent<Collider2D>();
    }
    private void Update()
    {
        DestroyWall();
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("カベに何か当たった");
        switch (col.gameObject.tag)
        {
            case "Player":
                col2d.isTrigger = true;
                player.OnCollisionEnter2D(col);
                foreach (Transform child in gameObject.transform)
                {
                    Destroy(child.gameObject);
                }
                Debug.Log("カベにプレイヤーが当たった");
                break;

            case "bomb":
                Destroy(this.gameObject);
                Debug.Log("カベに爆弾が当たった");
                break;
        }
    }

    private void DestroyWall()
    {
        if (this.transform.position.x  < player.transform.position.x)
        {
            Destroy(this);
        }
    }
}
