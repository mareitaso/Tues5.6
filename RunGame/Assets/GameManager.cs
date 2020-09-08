using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : SingletonMonoBehaviour<GameManager>
{
    public bool gameNow = true;

    [SerializeField]
    private GameObject panel;

    public Text endScore;

    [SerializeField]
    private Image getKeyImage;

    private float getTime = 3f;

    void Start()
    {
        getTime = 3f;
        gameNow = true;
        panel.SetActive(false);
    }

    void Update()
    {
        Result();
    }

    private void Result()
    {
        if (gameNow == false)
        {
            panel.SetActive(true);

            if (Input.GetKey(KeyCode.Space))
            {
                getTime -= Time.deltaTime;
                getKeyImage.fillAmount = getTime / 2;
                if (getTime < 0)
                {
                    //シーン移動
                    Debug.Log("");
                }
            }
            if (Input.GetKeyUp(KeyCode.Space))
            {
                getTime = 2;
                getKeyImage.fillAmount = getTime / 2;
            }
        }
    }
}
