using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;


public enum SCENE_TYPE
    {
        title,
        main,
        result,
        test,
        SampleScene,
    }

public class SceneMove
{
    public static void LoadScene(SCENE_TYPE _scene)
    {
        SceneManager.LoadScene((int)_scene);
    }
    
}

//public class SceneMove
//{

//}


/*  迷走中
  
 : SingletonMonoBehaviour<SceneMove>
    private void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    public void aho(SCENE_TYPE sceneType)
    {
        if (Input.GetMouseButtonDown(0))
        {
            StartCoroutine(Anime(sceneType));
        }
    }

    private IEnumerable Anime(SCENE_TYPE sceneType)
    {
        yield return new WaitForSeconds(0);
        yield return SceneManager.LoadSceneAsync(sceneType.ToString(), LoadSceneMode.Single);
        Resources.UnloadUnusedAssets();
    }
 
    private Dictionary<SCENE_TYPE, string> m_senenName = new Dictionary<SCENE_TYPE, string>
    {
        { SCENE_TYPE.main,      "main" },
        { SCENE_TYPE.title,     "title" },
        { SCENE_TYPE.result,    "result" },
        { SCENE_TYPE.test,      "test" },
        { SCENE_TYPE.scene,     "scene" },
    };

    public void LoadMoveScene(SCENE_TYPE scene_Type)
    {
        SceneManager.LoadScene(m_senenName[scene_Type]);
    }

*/

/*
・シングルトンは
・わからないことはメモる
・人と比べるのはよくない
・本田35式認知テスト
・言ったことをメモを取り。確認もする
・とにかくメモる
・Mグラム
 */
