using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : SingletonMonoBehaviour<Manager>
{
    [SerializeField]
    private PlayerController playerController;
    
    private float gameTime;

    [SerializeField]
    private float speedUpTime;
    
    void Start()
    {
        gameTime = 0;
    }

    void Update()
    {
        TimeManager();
    }

    private void TimeManager()
    {
        gameTime += Time.deltaTime;
        if (gameTime > speedUpTime)
        {
            gameTime = 0;
            playerController.SpeedUp();
        }
    }
}
