using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIActionMenu_C : MonoBehaviour
{
   
    public Button btnTraining;
    public Button btnBattle; 
    public Button btnHeal;

    public UIProfile_C profile;

    void Start()
    {
        btnBattle.onClick.AddListener(OnClickbtnBattle);

    }

    // Update is called once per frame
    void OnClickbtnBattle()
    {
        SceneManager_C.GetInstance().ChangeScene(Scene.Battle);
    }
}
