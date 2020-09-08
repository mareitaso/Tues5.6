using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage : MonoBehaviour
{
    private const int StageTipSize = 30;

    private int currentTipIndex;

    [SerializeField]
    private Transform character;

    [SerializeField]
    private GameObject[] stageTips;

    [SerializeField]
    private int startTipIndex;

    [SerializeField]
    private int preInstantiate;

    [SerializeField]
    private List<GameObject> generatedStageList = new List<GameObject>();

    void Start()
    {
        currentTipIndex = startTipIndex - 1;
        UpdateStage(preInstantiate);
    }


    void Update()
    {
        int charaPositionIndex = (int)(character.position.x / StageTipSize);
        if (charaPositionIndex + preInstantiate > currentTipIndex)
        {
            UpdateStage(charaPositionIndex + preInstantiate);
        }

    }
    //指定の場所までのステージを生成
    private void UpdateStage(int toTipIndex)
    {
        if (toTipIndex <= currentTipIndex) return;

        for (int i = currentTipIndex + 1; i <= toTipIndex; i++)
        {
            GameObject stageObject = GenerateStage(i);

            generatedStageList.Add(stageObject);
        }
        
        while (generatedStageList.Count > preInstantiate + 2) DestroyOldestStage();

        currentTipIndex = toTipIndex;
    }

    //ステージの生成
    private GameObject GenerateStage(int tipIndex)
    {
        int nextStageTip = Random.Range(0, stageTips.Length);

        GameObject stageObject = (GameObject)Instantiate(
            stageTips[nextStageTip],
            new Vector3(tipIndex * StageTipSize, 0, 0),
            Quaternion.identity);
        return stageObject;
    }

    //一番古いステージを消す
    private void DestroyOldestStage()
    {
        GameObject oldStage = generatedStageList[0];
        generatedStageList.RemoveAt(0);
        Destroy(oldStage);
    }

}
