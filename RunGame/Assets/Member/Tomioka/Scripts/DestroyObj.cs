using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObj : MonoBehaviour
{
    [SerializeField]
    private PlayerController player;

    private float x, y;

    private void Update()
    {
        DestroyerMove();
    }

    private void DestroyerMove()
    {
        x = player.transform.position.x;
        y = player.transform.position.y;
        this.transform.position = new Vector2(x,y);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(other.gameObject);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        Destroy(col.gameObject);
    }

}
