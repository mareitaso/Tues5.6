using BirdStrike.MIKOMA.Scripts.Utilities.SceneDataPacks;
using BirdStrike.MIKOMA.Scripts.Utilities.Transition;
using UnityEngine;

namespace BirdStrike.MIKOMA.Scripts.Utilities
{
    public static class SceneLoader
    {
        /// <summary>
        /// 前のシーンから引き継いだデータ
        /// </summary>
        //public static SceneDataPack PreviousSceneData;

        /// <summary>
        /// シーン遷移マネージャ
        /// </summary>
        private static SceneMove _transitionManager;

        /// <summary>
        /// シーン遷移マネージャ
        /// (存在しない場合は生成する)
        /// </summary>
        private static SceneMove TransitionManager
        {
            get
            {
                if (_transitionManager != null) return _transitionManager;
                
                return _transitionManager;
            }
        }

        /// <summary>
        ///　シーン遷移処理中か
        /// </summary>
        //public static bool IsTransitionRunning
        //{
        //    get { return TransitionManager.IsRunning; }
        //}

        /// <summary>
        /// シーン遷移を行う
        /// </summary>
        /// <param name="scene">次のシーン</param>
        /// <param name="data">次のシーンへ引き継ぐデータ</param>
        /// <param name="additiveLoadScenes">追加でロードするシーン</param>
        /// <param name="autoMove">トランジションアニメーションを自動的に完了させるか
        ///                        falseの場合はOpen()を実行しないとトランジションが終了しない</param>
        public static void LoadScene(SCENE_TYPE scene
            //SceneDataPack data = null,
            //SCENE_TYPE[] additiveLoadScenes = null
            )
        {
            //if (data == null)
            //{
            //    //引き継ぐデータが未指定の場合はシーン情報のみを詰める
            //    data = new DefaultSceneDataPack(TransitionManager.CurrentGameScene, additiveLoadScenes);
            //}
            TransitionManager.StartTransaction(scene);
        }
    }
}
