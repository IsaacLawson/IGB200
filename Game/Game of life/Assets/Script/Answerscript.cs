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
        //If the player clicks on the correct button during the minigame, then they will get a "Correct" outcome for picking the right choice
        if (isCorrect)
        {
            Debug.Log("Correct");
            quizManager.correct();
        }
        else
        //If the player clicks on the incorrect button during the minigame, then they will get a "Incorret" outcome for picking the right
        {
            Debug.Log("Incorrect");
            quizManager.correct();
        }
    }
}