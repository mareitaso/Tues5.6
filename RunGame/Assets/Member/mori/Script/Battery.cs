using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battery : MonoBehaviour
{
    [SerializeField]
    GameObject BatteryBullet;
    float _time = 2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _time -= Time.deltaTime;
        
        if(_time <= 0)
        {
            Instantiate(BatteryBullet, transform.position, Quaternion.Euler(0,0,180f));
            _time = 3; 
        }
    }
}
