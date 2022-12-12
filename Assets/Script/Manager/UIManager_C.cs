using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using UnityEngine;
using UnityEngine.EventSystems;

public class UIManager_C : MonoBehaviour
{
    #region Singletone
    private static UIManager_C instance = null;

    public static UIManager_C GetInstance()
    {
        if (instance == null)
        {
            GameObject go = new GameObject("UIManager");
            instance = go.AddComponent<UIManager_C>();

            DontDestroyOnLoad(go);

        }

        return instance;

    }
    #endregion

    #region UI Control

    public void SetEventSystem()
    {
        if(FindObjectOfType<EventSystem>() == false)
        { 
            GameObject go = new GameObject("@EventSystem");
            go.AddComponent<EventSystem>();
            go.AddComponent<StandaloneInputModule>();
        
        }    

    }

    Dictionary<string, GameObject> uiList = new Dictionary<string, GameObject>();
    
    public void OpenUI(string uiName)
    {
        if (uiList.ContainsKey(uiName) == false)
        {
            Object uiObject = Resources.Load("UI/"+uiName);           //  府家胶 肺靛
            GameObject go = (GameObject)Instantiate(uiObject);  //  肺靛等 府家胶 积己

            uiList.Add(uiName, go);

        }

        else
        { uiList[uiName].SetActive(true); }

    }

    public void CloseUI(string uiName)
    {
        if (uiList.ContainsKey(uiName))
        { uiList[uiName].SetActive(false);}

    }

    //public void OpenResult(string uiResult)
    //{ Object uiResult = Resources.Load("UI/UIResult"); }

    //public void CloseResult()
    //{ Object uiResult = Resources.Load("UI/UIResult"); }
    
    #endregion

    public GameObject GetUI(string uiName)
    { 
        if(uiList.ContainsKey(uiName))
        { return uiList[uiName]; }
            
        return null; 
    }

    public void ClearList()
    { uiList.Clear(); }


    
}
