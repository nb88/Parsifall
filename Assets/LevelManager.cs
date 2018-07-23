using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

    public static LevelManager Instance
    {
        get { return _instance ? _instance : new GameObject("LevelManager").AddComponent<LevelManager>(); }
    }

    private static LevelManager _instance;

    private void Awake()
    {
        if (_instance)
        {
            Destroy(gameObject);
            return;
        }

        _instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void LoadGame()
    {
        Application.LoadLevel("Game Scene");
       // SceneManager.LoadScene("loadscene");
    }

    public void LoadCredits()
    {
        Application.LoadLevel("Credits");
        // SceneManager.LoadScene("loadscene");
    }

    public void LoadBack()
    {
        Application.LoadLevel("Start");
        // SceneManager.LoadScene("loadscene");
    }
}
