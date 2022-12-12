using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainScene_C : MonoBehaviour
{
    

    void Start()
    {
        GameObject player = ObjectManager_C.GetInstance().CreateCharacter();
        player.transform.localScale = new Vector3(2, 2, 2);
        player.transform.localPosition = new Vector3(0, 0.6f, 0);

        UIManager_C.GetInstance().SetEventSystem();
        UIManager_C.GetInstance().OpenUI("UIProfile");
        UIManager_C.GetInstance().OpenUI("UIActionMenu");

    }

  
}
