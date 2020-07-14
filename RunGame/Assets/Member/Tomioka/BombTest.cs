using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombTest : MonoBehaviour
{
    void Start()
    {
        UseBomb(new Vector2(1000,1000));
    }

    void Update()
    {
        
    }

    public void UseBomb(Vector2 direction)
    {
        GetComponent<Rigidbody2D>().AddForce(direction);
        Debug.Log("呼ばれた");
    }

}
