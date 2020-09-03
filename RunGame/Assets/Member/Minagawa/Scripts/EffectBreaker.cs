using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectBreaker : MonoBehaviour
{
    void Start()
    {
        //エフェクトが生成されて1秒後にオブジェクトを削除する
        Invoke("BreakEffect", 1.0f);
    }

    //エフェクト(自分自身)を削除する
    void BreakEffect()
    {
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
