using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallTest : MonoBehaviour
{
    [SerializeField]
    PlayerController player;

    private Collider2D col2d;

    private void Start()
    {
        col2d = GetComponent<Collider2D>();
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("カベに何か当たった");
        switch (col.gameObject.tag)
        {
            case "Player":
                col2d.isTrigger = true;
                player.OnCollisionEnter2D(col);
                Debug.Log("カベにプレイヤーが当たった");
                break;

            case "bomb":
                Destroy(this.gameObject);
                Debug.Log("カベに爆弾が当たった");
                break;
        }


    }
}
