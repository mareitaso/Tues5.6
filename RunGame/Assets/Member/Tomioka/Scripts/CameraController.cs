using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    private GameObject player;

    [SerializeField]
    private float x, y, z;

    void Start()
    {
        x = player.transform.position.x + 7;
        z = this.transform.position.z;
    }

    void Update()
    {
        x = player.transform.position.x + 7;
        this.transform.position = new Vector3(x, y, z);
    }
}
