using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;
using System.Linq;
using System.Text;
using System;
using System.Data.SqlTypes;
using BirdStrike.MIKOMA.Scripts.Utilities.SceneDataPacks;
using UnityEngine.UI;

public enum SCENE_TYPE
    {
        title,
        main,
        result,
        test,
        SampleScene,
    }

namespace BirdStrike.MIKOMA.Scripts.Utilities.SceneDataPacks
{
    /// <summary>
    /// シーンをまたいでデータを受け渡すときに利用する
    /// </summary>
    public abstract class SceneDataPack
    {
        /// <summary>
        /// 前のシーン
        /// </summary>
        public abstract SCENE_TYPE PreviousGameScene { get; }

        /// <summary>
        /// 前シーンで追加ロードしていたシーン一覧
        /// </summary>
        public abstract SCENE_TYPE[] PreviousAdditiveScene { get; }
    }

    /// <summary>
    /// デフォルト実装
    /// </summary>
    public class DefaultSceneDataPack : SceneDataPack
    {
        private readonly SCENE_TYPE _prevGameScenes;
        private readonly SCENE_TYPE[] _additiveScenes;

        public SCENE_TYPE[] AdditiveScenes
        {
            get { return _additiveScenes; }
        }

        public override SCENE_TYPE PreviousGameScene
        {
            get { return _prevGameScenes; }
        }

        public override SCENE_TYPE[] PreviousAdditiveScene
        {
            get { return null; }
        }

        public DefaultSceneDataPack(SCENE_TYPE prev, SCENE_TYPE[] additive)
        {
            _prevGameScenes = prev;
            _additiveScenes = additive;
        }
    }
}

namespace BirdStrike.MIKOMA.Scripts.Utilities.Transition
{
    /// <summary>
    /// シーン遷移を管理する
    /// </summary>
    public class SceneMove : SingletonMonoBehaviour<SceneMove>
    {
        /// <summary>
        /// シーン遷移処理を実行中であるか
        /// </summary>
        private bool _isRunning = false;

        public bool IsRunning { get { return _isRunning; } }

        private SCENE_TYPE _currentGameScene;

        /// <summary>
        /// 現在のシーン情報
        /// </summary>
        public SCENE_TYPE CurrentGameScene
        {
            get { return _currentGameScene; }
        }


        private void Awake()
        {
            //勝手に消さない
            DontDestroyOnLoad(gameObject);

            try
            {
                //現在のシーンを取得する
                _currentGameScene =
                    (SCENE_TYPE)Enum.Parse(typeof(SCENE_TYPE), SceneManager.GetActiveScene().name, false);
            }
            catch
            {
                Debug.Log("現在のシーンの取得に失敗");
                _currentGameScene = SCENE_TYPE.main; //Debugシーンとかの場合は適当なシーンで埋めておく
            }
        }

        /// <summary>
        /// シーン遷移を実行する
        /// </summary>
        /// <param name="nextScene">次のシーン</param>
        /// <param name="data">次のシーンへ引き継ぐデータ</param>
        /// <param name="additiveLoadScenes">追加ロードするシーン</param>
        /// <param name="autoMove">トランジションの自動遷移を行うか</param>
        public void StartTransaction(
            SCENE_TYPE nextScene,
            SceneDataPack data,
            SCENE_TYPE[] additiveLoadScenes
            
            )
        {
            if (_isRunning) return;
            StartCoroutine(TransitionCoroutine(nextScene, data, additiveLoadScenes));
        }

        /// <summary>
        /// シーン遷移処理の本体
        /// </summary>
        private IEnumerator TransitionCoroutine(
            SCENE_TYPE nextScene,
            SceneDataPack data,
            SCENE_TYPE[] additiveLoadScenes
            
            )
        {
            //処理開始フラグセット
            _isRunning = true;

            //前のシーンから受け取った情報を登録
            SceneLoader.PreviousSceneData = data;

            //メインとなるシーンをSingleで読み込む
            yield return SceneManager.LoadSceneAsync(nextScene.ToString(), LoadSceneMode.Single);

            yield return null;

            //使ってないリソースの解放とGCを実行
            Resources.UnloadUnusedAssets();
            GC.Collect();

            yield return null;

            //現在シーンを設定
            _currentGameScene = nextScene;

            //終了
            _isRunning = false;
        }
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
