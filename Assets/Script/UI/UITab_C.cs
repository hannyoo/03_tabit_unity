using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UITab_C : MonoBehaviour
{
    public Button btnTab;
    
    // Start is called before the first frame update
    void Start()
    {
        btnTab = GetComponentInChildren<Button>();
        btnTab.onClick.AddListener(OnTab);
    }

    // Update is called once per frame
    void OnTab()
    {
        Debug.Log(" Ај Ан ");
        BattleManager_C.GetInstance().AttackMonster();
    }
}
