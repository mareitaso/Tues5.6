using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombTest : MonoBehaviour
{
    [SerializeField]
    private GameObject bombEffect;

    private GameObject bomb;

    void Start()
    {
        UseBomb(new Vector2(700, 300));
    }
    public void UseBomb(Vector2 direction)
    {
        GetComponent<Rigidbody2D>().AddForce(direction);
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == ("wall"))
        {
            Destroy(this.gameObject);
        }
        if (col.gameObject.tag == ("Stage"))
        {
            Invoke("OldBomb", 0.5f);
        }
    }

    private void OldBomb()
    {
        bomb = Instantiate(bombEffect, new Vector2(this.transform.position.x, this.transform.position.y), Quaternion.identity);
        this.gameObject.SetActive(false);
        Invoke("DestroyBomb", 0.5f);
    }

    private void DestroyBomb()
    {
        Destroy(bomb);
        Destroy(this.gameObject);
    }
}
