using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Question[] questions;
    private static List<Question> unansweredQuestions;

    private Question currentQuestion;

    [SerializeField]
    private Text TrueAnswerText;

    [SerializeField]
    private Text FalseAnswerText;

    [SerializeField]
    private float timeBetweenQuestions = 1f;

    // [SerializeField]
    // private Animator animator;

    [SerializeField] private AudioSource IncorrectAnswer;
    [SerializeField] private AudioSource CorrectAnswer;

    [SerializeField]
    private Text factText;


    void Start()
    {
        if (unansweredQuestions == null || unansweredQuestions.Count == 0)
        {
            unansweredQuestions = questions.ToList<Question>();
        }

        SetCurrentQuestion();
    }

    void SetCurrentQuestion ()
    {
        int randomQuestionIndex = Random.Range(0, unansweredQuestions.Count);
        currentQuestion = unansweredQuestions[randomQuestionIndex];

        factText.text = currentQuestion.fact;

        if (currentQuestion.isTrue)
        {
            TrueAnswerText.text = "Correct";
            FalseAnswerText.text = "Incorrect";
        } else
        {
            TrueAnswerText.text = "Incorrect";
            FalseAnswerText.text = "Correct";
        }
        gamemanager.quizval += 1;
        Debug.Log(gamemanager.quizval);
    }

    IEnumerator TransitionToNextQuestion ()
    {
        unansweredQuestions.Remove(currentQuestion);

        yield return new WaitForSeconds(timeBetweenQuestions);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void UserSelectTrue ()
    {
        //animator.SetTrigger("True");
        if (currentQuestion.isTrue)
        {
            CorrectAnswer.Play();
            Debug.Log("Correct!");
        } else
        {
            IncorrectAnswer.Play();
            Debug.Log("Incorrect!");
        }

        StartCoroutine(TransitionToNextQuestion());
    }
    public void UserSelectFalse()
    {
        //animator.SetTrigger("False");
        if (currentQuestion.isTrue)
        {
            CorrectAnswer.Play();
            Debug.Log("Correct!");
        }
        else
        {
            IncorrectAnswer.Play();
            Debug.Log("Incorrect!");
        }

        StartCoroutine(TransitionToNextQuestion());
    }
}
