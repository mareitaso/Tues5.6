using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombCol : MonoBehaviour
{
    [SerializeField]
    private PlayerController player;

    public void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            player.jumpCom = false;
            player.playerHP -= 3;
        }
    }

    public void OnCollisionExit2D(Collision2D col)
    {
        player.jumpCom = false;
    }
}
