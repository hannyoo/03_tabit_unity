using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    #region Singletone
    private static GameManager instance = null;

    public static GameManager GetInstance()
    {
        if (instance == null)
        {
            GameObject go = new GameObject("ObjectManager");
            instance = go.AddComponent<GameManager>();

            DontDestroyOnLoad(go);

        }

        return instance;

    }
    #endregion

    public string playerName = "kHANN";
    public int level = 99;
    public int gold = 500;

    public int curgold;
    
    public int totalHp = 100;
    public int curHp = 100;

    public void AddGold(int gold)

    { this.gold += gold; }

    public bool SpendGold(int gold)
    {
        if(this.gold >= gold)
        { 
            this.gold -= gold;
            return true; 

        }

        return false;
    }

    public void IncreaseTotalHp(int addHp)
    { totalHp += addHp; }

    public void SetCurrentHp(int hp)
    { 
        curHp += hp; 
       
        curHp = Mathf.Clamp(curHp, 0, 100);
       
    }

    public void Heal()
    {

    }

}
