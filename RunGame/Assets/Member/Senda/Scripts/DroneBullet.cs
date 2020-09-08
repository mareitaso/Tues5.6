using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneBullet : DroneMove
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 force;

        force = this.gameObject.transform.up * bulletspeed;

        this.GetComponent<Rigidbody2D>().AddForce(force);
    }
}
