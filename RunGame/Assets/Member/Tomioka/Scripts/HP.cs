using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HP : MonoBehaviour
{
    [SerializeField]
    private Image HPBar;

    [SerializeField]
    private PlayerController player;

    private float nowHP, maxHP;

    private void Start()
    {
        maxHP = player.playerHP;
    }

    private void Update()
    {
        nowHP = player.playerHP;
        HPBar.fillAmount = player.playerHP / maxHP;
    }

}
