using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMainMenu_C : MonoBehaviour
{
    Button btnStart;

    void Start()
    {
        btnStart = GetComponentInChildren<Button>();
        btnStart.onClick.AddListener(OnClickStart);
    }

   
    void OnClickStart()
    {
        SceneManager_C.GetInstance().ChangeScene(Scene.Main);
    }
}
