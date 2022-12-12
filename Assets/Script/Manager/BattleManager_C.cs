using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleManager_C : MonoBehaviour
{
    #region Singletone
    private static BattleManager_C instance = null;

    public static BattleManager_C GetInstance()
    {
        if (instance == null)
        {
            GameObject go = new GameObject("BattleManager");
            instance = go.AddComponent<BattleManager_C>();

            DontDestroyOnLoad(go);

        }

        return instance;

    }
    #endregion

    public Monster1_C monsterData;

    GameObject uiTab;



    public void BattleStart(Monster1_C monster)
    {
        monsterData = monster;

        StartCoroutine("BattleProgress");

        UIManager_C.GetInstance().OpenUI("UITab");
      
    }




    IEnumerator BattleProgress()
    {
        while(GameManager.GetInstance().curHp>0)
        {
            yield return new WaitForSeconds(monsterData.delay);
            
            int damage = monsterData.atk;
            GameManager.GetInstance().SetCurrentHp(-damage);
            Debug.Log($" {damage}만큼 공격 당했습니다! 남은체력 ; {GameManager.GetInstance().curHp}");

           GameObject ui = UIManager_C.GetInstance().GetUI("UIProfile");
            if(ui != null)
            { 
                ui.GetComponent<UIProfile_C>().RefreshState();  
            }
        
        }

        Lose();

    }

    public void AttackMonster()
    {
        float rndmX = Random.Range(-1.8f, 1.2f);
        float rndmY = Random.Range(-1.2f, 1.2f);

        var particle = ObjectManager_C.GetInstance().CreateHitEffect();
        particle.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        particle.transform.localPosition = new Vector3(0+rndmX, 0.7f+rndmY, 0.5f);


        monsterData.hp--;

        if(monsterData.hp <= 0 )
        { Victory(); }

    }


    void Victory()
    {
        Debug.Log(" 승 리 ");
        StopCoroutine("BattleProgress");
        UIManager_C.GetInstance().CloseUI("UITab");

        GameManager.GetInstance().AddGold(monsterData.gold);

            

        Invoke("MoveToMain", 1.5f);
    }

    void Lose()
    {
        Debug.Log(" 패 배 ");
        UIManager_C.GetInstance().CloseUI("UITab");

       
        if (GameManager.GetInstance().SpendGold(500))
        { GameManager.GetInstance().SetCurrentHp(80); }

        else { GameManager.GetInstance().SetCurrentHp(10); }




        Invoke("MoveToMain", 1.5f);


    }

    void MoveToMain()
    {
        SceneManager_C.GetInstance().ChangeScene(Scene.Main);

    }

}
