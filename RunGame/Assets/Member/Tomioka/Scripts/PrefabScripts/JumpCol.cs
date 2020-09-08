using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpCol : MonoBehaviour
{
    [SerializeField]
    private PlayerController player;

    public void OnCollisionEnter2D(Collision2D col)
    {
        if (player.jumpCom == true && Input.GetKeyDown(KeyCode.Space))
        {
            player.Jump();
        }
    }
}
