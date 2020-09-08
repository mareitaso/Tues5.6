using UnityEngine.SceneManagement;
using System;
using UnityEngine;

// 
[Serializable]
public enum SCENE_TYPE
    {
        title,
        main,
        result,
        test,
        SampleScene,
    }

public class SceneMove : MonoBehaviour
{
    // クラス名＋Instance.でクラス内の public な関数を呼び出せる
    public static SceneMove Instance { get { return _instance; } }
    // SceneMoveのInstanceを作成
    static SceneMove _instance;

    // シーンの名前を入れる一時的な string
    string _sceneName = null;

    void Awake()
    {
        // instanceに自分のクラスを代入
        _instance = this;
    }
    /// <summary>
    /// シーン呼び出し用
    /// </summary>
    /// <param name="_scene">呼び出したいSceneを入れる</param>
    public void LoadScene(SCENE_TYPE _scene)
    {
        switch (_scene) 
        {
            case SCENE_TYPE.title: _sceneName = "Title"; break;
            case SCENE_TYPE.main: _sceneName = "Main"; break;
            case SCENE_TYPE.result: _sceneName = "Result"; break;
        }

        if(null != _sceneName) SceneManager.LoadScene(_sceneName);
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
