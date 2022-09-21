using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Answerscript : MonoBehaviour
{
    public bool isCorrect = false;
    public Quizminigamemanager quizManager;
    public void answer()
    {
        if(isCorrect)
        {
            Debug.Log("Correct");
            quizManager.correct();
        }
        else
        {
            Debug.Log("Incorrect");
            quizManager.correct();
        }

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
