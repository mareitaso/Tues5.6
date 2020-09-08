using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCreate : MonoBehaviour
{
    [SerializeField]
    private PlayerController player;

    [SerializeField]
    private GameObject wallPrefab;
    [SerializeField]
    private GameObject dronePrefab;
    [SerializeField]
    private GameObject cannonPrefab;

    [SerializeField]
    private bool generatWall, generatDrone, generatCannon;

    //時間間隔の最小値と最大
    [SerializeField]
    private float minTime, maxTime;

    private float intervalW, intervalD, intervalC;

    //経過時間
    private float time = 0f;

    // Start is called before the first frame update
    void Start()
    {
        intervalW = GetRandomTime();
        intervalD = GetRandomTime();
        intervalC = GetRandomTime();
    }

    // Update is called once per frame
    void Update()
    {
        //時間計測
        time += Time.deltaTime;
        CreateD();
        CreateW();
        CreateC();
    }

    private void CreateD()
    {
        //経過時間が生成時間になったとき(生成時間より大きくなったとき)
        if (time > intervalD & generatDrone == true)
        {
            GameObject drone = Instantiate(dronePrefab);

            drone.transform.position = new Vector2(player.transform.position.x + 30, +2.83f);

            //経過時間初期化
            time = 0f;

            intervalD = GetRandomTime();
        }
    }

    private void CreateW()
    {
        //経過時間が生成時間になったとき(生成時間より大きくなったとき)
        if (time > intervalW &&generatWall == true)
        {
            GameObject wall = Instantiate(wallPrefab);

            wall.transform.position = new Vector2(player.transform.position.x + 30, -2.83f);

            //経過時間初期化
            time = 0f;

            intervalW = GetRandomTime();
        }
    }

    private void CreateC()
    {
        //経過時間が生成時間になったとき(生成時間より大きくなったとき)
        if (time > intervalC && generatCannon ==true)
        {
            GameObject cannon = Instantiate(cannonPrefab);

            cannon.transform.position = new Vector2(player.transform.position.x + 30, -2.83f);

            //経過時間初期化
            time = 0f;

            intervalC = GetRandomTime();
        }
    }

    //ランダムな時間を生成
    private float GetRandomTime()
    {
        return Random.Range(minTime, maxTime);
    }
}
