﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResultDirector : MonoBehaviour
{
    public void OnClickStartButton()
    {
        SceneManager.LoadScene("TitleScene");
    }
}
