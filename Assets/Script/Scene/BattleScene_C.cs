using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleScene_C : MonoBehaviour
{

    void Start()
    {
        GameObject go = ObjectManager_C.GetInstance().CreateMonster();
        go.transform.localScale = new Vector3(2, 2, 2);
        go.transform.localPosition = new Vector3(0, 0.6f, 0);

        UIManager_C.GetInstance().SetEventSystem();
        UIManager_C.GetInstance().OpenUI("UIProfile");

        BattleManager_C.GetInstance().BattleStart(new Monster1_C());


    }

}
