using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIProfile_C : MonoBehaviour
{
    public Slider hpBar;
    public Image imgFill;

    public TMP_Text txtLevel;
    public TMP_Text txtName;
    public TMP_Text txtGold;
    public TMP_Text txtHp;

    void Start()
    {
        RefreshState();
    }

    public void RefreshState()
    {
        txtLevel.text = $"Lv.{GameManager.GetInstance().level}";
        txtName.text = $"{GameManager.GetInstance().playerName}";
        txtGold.text = $"{GameManager.GetInstance().gold} G";

        hpBar.maxValue = GameManager.GetInstance().totalHp;
        hpBar.value = GameManager.GetInstance().curHp;
        txtHp.text = $"{hpBar.value}/100";


    }

}
