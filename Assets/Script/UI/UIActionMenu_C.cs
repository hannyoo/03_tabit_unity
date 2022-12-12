using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIActionMenu_C : MonoBehaviour
{
   
    public Button btnTraining;
    public Button btnBattle; 
    public Button btnHeal;
    public Button btnQuiz;

    public UIProfile_C profile;

    void Start()
    {
        btnBattle.onClick.AddListener(OnClickbtnBattle);

        btnQuiz.onClick.AddListener(OnClickbtnQuiz);

        btnQuiz.onClick.AddListener(OnClickHeal);

        btnQuiz.onClick.AddListener(OnClickbtnTraining);
    }

    // Update is called once per frame
    void OnClickbtnBattle()
    {
        SceneManager_C.GetInstance().ChangeScene(Scene.Battle);
    }

    public void OnClickHeal()
    {
        GameManager.GetInstance().SetCurrentHp(GameManager.GetInstance().totalHp / 3);
        GameManager.GetInstance().SpendGold(100);
        //var healEffect = ObjectManager_C.GetInstance().CreateHealEffect("Effect/Level_Up_green");
        //healEffect.transform.localScale = new Vector3(2, 2, 2);
        //healEffect.transform.localPosition = new Vector3(0, 0.6f, 0);

    }
    void OnClickbtnTraining()
    {
        SceneManager_C.GetInstance().ChangeScene(Scene.Training);
    }
    void OnClickbtnQuiz()
    {
        SceneManager_C.GetInstance().ChangeScene(Scene.Quiz);
    }


}
