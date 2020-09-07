using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    GameObject player;
    [SerializeField]
    float _speed;
    [SerializeField]
    float _timar;
    bool IsArrivedDestination;
    [SerializeField]
    PlayerController player2;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        switch (col.gameObject.tag)
        {
            case "Player":
                //col2d.isTrigger = true;
                player2.playerHP -= 3;
                Debug.Log("弾がプレイヤーが当たった");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        _timar -= Time.deltaTime;
        Vector2 tagetPos = player.transform.position;

        if(_timar <= 0 )
        {
            Destroy(gameObject);
        }

        if(transform.position.x == tagetPos.x)
        {
            IsArrivedDestination = true;
        }

        if (!IsArrivedDestination)
        {
            transform.position = new Vector2(Mathf.MoveTowards
            (transform.position.x, tagetPos.x, Time.deltaTime * _speed), transform.position.y);
        }
        if(IsArrivedDestination)
        {
            transform.position += new Vector3(-_speed * Time.deltaTime, 0, 0);
        }
        Debug.Log((int)_timar);
    }
}
