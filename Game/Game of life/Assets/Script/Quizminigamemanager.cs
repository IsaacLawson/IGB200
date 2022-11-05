using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quizminigamemanager : MonoBehaviour
{
    public List<Quizminigame> QnA;
    public GameObject[] options;
    public int currentQuestion;

    public Text QuestionTxt;

    // Start is called before the first frame update
    private void Start()
    {
        generateQuestion();
    }
    public void correct()
    {
        QnA.RemoveAt(currentQuestion);
        generateQuestion();
    }
    void setAnswer()
    {
        for (int i = 0; i < options.Length; i++)
        {
            options[i].GetComponent<Answerscript>().isCorrect = false;
            options[i].transform.GetChild(0).GetComponent<Text>().text = QnA[currentQuestion].answer[i];

            if (QnA[currentQuestion].correctanswer == i + 1)
            {
                options[i].GetComponent<Answerscript>().isCorrect = true;
            }
        }
    }
    void generateQuestion()
    {
        currentQuestion = Random.Range(0, QnA.Count);
        QuestionTxt.text = QnA[currentQuestion].questions;
        setAnswer();
    }
}
