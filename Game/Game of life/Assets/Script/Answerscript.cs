using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Answerscript : MonoBehaviour
{
    public bool isCorrect = false;
    public Quizminigamemanager quizManager;
    public void answer()
    {
        if (isCorrect)
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
}