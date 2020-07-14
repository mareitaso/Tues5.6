using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;
using System.Linq;
using System.Text;
using System;

public class SceneMove
{
    public enum SCENE_TYPE
    {
        title,
        main,
        result,
        test,
    }

    private Dictionary<SCENE_TYPE, string> m_senenName = new Dictionary<SCENE_TYPE, string>
    {
        { SCENE_TYPE.main,"main" },
        { SCENE_TYPE.title, "title" },
        { SCENE_TYPE.result, "result" },
        { SCENE_TYPE.test, "test" },
    };
    public void LoadMoveScene(SCENE_TYPE scene_Type)
    {
        SceneManager.LoadScene(m_senenName[scene_Type]);
    }
}


/*
・シングルトンは
・わからないことはメモる
・人と比べるのはよくない
・本田35式認知テスト
・言ったことをメモを取り。確認もする
・とにかくメモる
・Mグラム
 */