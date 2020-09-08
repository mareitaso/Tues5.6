using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    public GameObject score_Text = null; // Textオブジェクト
    public float score_num = 0; // スコア変数

    // 初期化
    void Start()
    {
        score_num = 0;
    }

    // 更新
    void Update()
    {
        if (GameManager.instance.gameNow == true)
        {
            // オブジェクトからTextコンポーネントを取得
            Text score_text = score_Text.GetComponent<Text>();
            // テキストの表示を入れ替える
            score_text.text = "Score:" + score_num.ToString("f1");
            GameManager.instance.endScore.text = score_num.ToString("f1") + "点です";

            score_num += 0.1f; // とりあえず1加算し続けてみる
        }
    }
}