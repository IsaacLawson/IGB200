using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Scenemanager : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {


    }
    public void SwitchScene(string scenename)
    {
        gamemanager.clothesval = 0;
        SceneManager.LoadScene(scenename);
    }
    public void Quitgame()
    {
        Debug.Log("Quitting Game....");
        Application.Quit();
    }
}
