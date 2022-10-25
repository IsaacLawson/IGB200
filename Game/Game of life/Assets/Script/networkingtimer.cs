using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class networkingtimer : MonoBehaviour
{
public GameObject other;
    float currentTime = 0f;
    float startingTime = 100f;

    [SerializeField] Text countdownText;
    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
    }
    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString("0");

        if (currentTime <= 0)
        {
            SceneManager.LoadScene("Interviewlose");
        }
        else
        {
            int score = gamemanager.npcval;
            {
                if (score == 16)
                {
                    SceneManager.LoadScene("interviewwin");
                }
            }
        }
    }
}
