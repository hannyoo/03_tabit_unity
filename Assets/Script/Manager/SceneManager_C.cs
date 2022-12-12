using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public enum Scene
{ Menu, Main, Battle }


public class SceneManager_C : MonoBehaviour
{    
    #region Singletone
    private static SceneManager_C instance = null;

    public static SceneManager_C GetInstance()
    {
        if (instance == null)
        {
            GameObject go = new GameObject("SceneManager");
            instance = go.AddComponent<SceneManager_C>();

            DontDestroyOnLoad(go);

        }

        return instance;
        
    }
    #endregion

    #region Scene Control

    public Scene currentScene;
    public void ChangeScene(Scene scene)
    {
        UIManager_C.GetInstance().ClearList();

        currentScene = scene;
        SceneManager.LoadScene(scene.ToString());
    }

    #endregion

}

