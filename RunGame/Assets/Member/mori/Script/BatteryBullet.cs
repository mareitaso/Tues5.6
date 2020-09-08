using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryBullet : MonoBehaviour
{
    GameObject player;
    float _speed = 10f;
    float _timar = 5f;
    bool IsArrivedDestination;
    PlayerController player2;

    [SerializeField]
    private GameObject bombEffect;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        player2 = player.GetComponent<PlayerController>();
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        switch (col.gameObject.tag)
        {
            case "Player":
                //col2d.isTrigger = true;
                player2.PlayerDamage();
                Destroy(this.gameObject);
                Instantiate(bombEffect, new Vector2(this.transform.position.x, this.transform.position.y), Quaternion.identity);
                Debug.Log("弾がプレイヤーが当たった");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        _timar -= Time.deltaTime;
        Vector2 tagetPos = player.transform.position;

        if (_timar <= 0)
        {
            Destroy(gameObject);
        }

        if (transform.position.x == tagetPos.x)
        {
            IsArrivedDestination = true;
        }

        if (!IsArrivedDestination)
        {
            transform.position = new Vector2(Mathf.MoveTowards
            (transform.position.x, tagetPos.x, Time.deltaTime * _speed), transform.position.y);
        }
        if (IsArrivedDestination)
        {
            transform.position += new Vector3(-_speed * Time.deltaTime, 0, 0);
        }
        //Debug.Log((int)_timar);
    }
}
