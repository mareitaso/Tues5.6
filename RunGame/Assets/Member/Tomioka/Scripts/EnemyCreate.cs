using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCreate : MonoBehaviour
{
    [SerializeField]
    private PlayerController player;

    [SerializeField]
    private GameObject wallPrefab;

    //時間間隔の最小値と最大
    [SerializeField]
    private float minTime, maxTime;

    private float interval;

    //経過時間
    private float time = 0f;

    // Start is called before the first frame update
    void Start()
    {
        interval = GetRandomTime();
    }

    // Update is called once per frame
    void Update()
    {
        //時間計測
        time += Time.deltaTime;

        //経過時間が生成時間になったとき(生成時間より大きくなったとき)
        if (time > interval)
        {
            GameObject wall = Instantiate(wallPrefab);

            wall.transform.position = new Vector2(player.transform.position.x + 30, -2.83f);

            //経過時間初期化
            time = 0f;

            interval = GetRandomTime();
        }
    }

    //ランダムな時間を生成
    private float GetRandomTime()
    {
        return Random.Range(minTime, maxTime);
    }
}
