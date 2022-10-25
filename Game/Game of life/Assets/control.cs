using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class control : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (gamemanager.first)
        {
            gamemanager.quizval = 0;
            gamemanager.first = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (gamemanager.quizval >= 4)
        {
            SceneManager.LoadScene("interviewwin");
        }
    }
}
