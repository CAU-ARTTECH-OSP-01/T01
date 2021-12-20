using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mainmenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnclickNewGame()
    {
        Debug.Log("New Game");
    }

    public void OnclickHighScore()
    {
        Debug.Log("High Score");
    }

    public void OnclickOption()
    {
        Debug.Log("Option");
    }

    public void OnclickQuit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }

    public void GoGameScene()
    {
      SceneManager.LoadScene(2);
    }

}
