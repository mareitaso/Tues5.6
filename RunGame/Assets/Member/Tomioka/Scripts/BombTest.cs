using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombTest : MonoBehaviour
{
    void Start()
    {
        UseBomb(new Vector2(700, 300));
    }
    public void UseBomb(Vector2 direction)
    {
        GetComponent<Rigidbody2D>().AddForce(direction);
        //Debug.Log("呼ばれた");
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == ("wall"))
        {
            Destroy(this.gameObject);
        }
    }
}
