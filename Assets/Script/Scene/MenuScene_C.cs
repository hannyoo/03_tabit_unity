using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScene_C : MonoBehaviour
{
   
    void Start()
    {
        UIManager_C.GetInstance().SetEventSystem();
        UIManager_C.GetInstance().OpenUI("UIMainMenu");
    }

}
