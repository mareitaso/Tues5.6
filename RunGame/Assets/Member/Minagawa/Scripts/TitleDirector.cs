using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class TitleDirector : MonoBehaviour
{
    public void OnClickStartButton()
    {
        SceneManager.LoadScene("Main");
    }

}
