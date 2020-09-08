using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    private Collider2D col2d;

    private void Start()
    {
        col2d = GetComponent<Collider2D>();
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("攻撃が当たった");
        switch (col.gameObject.tag)
        {
            case "Player":
                col2d.isTrigger = true;
                break;
        }
    }
}
