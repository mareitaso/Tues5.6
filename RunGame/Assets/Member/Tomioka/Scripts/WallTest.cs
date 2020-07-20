using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallTest : MonoBehaviour
{
    [SerializeField]
    PlayerController player;

    private void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("外側");
        switch (col.tag)
        {
            case "Player":

                break;

            case "bomb":
                Destroy(this.gameObject);
                Debug.Log("内側");
                break;
        }


    }
}
