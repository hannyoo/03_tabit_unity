using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectManager_C : MonoBehaviour
{

    #region Singletone
    private static ObjectManager_C instance = null;

    public static ObjectManager_C GetInstance()
    {
        if (instance == null)
        {
            GameObject go = new GameObject("ObjectManager");
            instance = go.AddComponent<ObjectManager_C>();

            DontDestroyOnLoad(go);

        }

        return instance;

    }
    #endregion

    public GameObject CreateCharacter()
    {
        Object characterObj = Resources.Load("Sprite/Skull");
        GameObject character = (GameObject)Instantiate(characterObj);

        return character;
    }
    
    
    public GameObject CreateMonster()
    {
        Object monsterObj = Resources.Load("Sprite/Monster");
        GameObject monster = (GameObject)Instantiate(monsterObj);

        return monster;
    }

    public ParticleSystem CreateHitEffect()
    {
        Object HitEffect = Resources.Load("Effect/Hit_3_normal");
        GameObject effect = (GameObject)Instantiate(HitEffect); 

        return effect.GetComponent<ParticleSystem>();
    }

    public ParticleSystem CreateHealEffect()
    {
        Object HealEffect = Resources.Load("Effect/Level_Up_green");
        GameObject effect = (GameObject)Instantiate(HealEffect);

        return effect.GetComponent<ParticleSystem>();
    }




}
