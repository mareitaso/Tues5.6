using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetItem : MonoBehaviour
{
    [SerializeField]
    private PlayerController player;

    private void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("何かに当たった");
        Debug.Log(collision.tag);
        if (collision.tag == "Player")
        {
            player.itemNum++;
            Destroy(this.gameObject);
        }
    }
}
