using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;
public class networkplayer : MonoBehaviour

{
    public TMP_Text interacttxt;
    public GameObject other;
    public GameObject npc;
    public bool interat;

    // Start is called before the first frame update
    void Start()
    {
        interacttxt.enabled = false;
        interat = false;
    }

    void update()
    {
        whatever();
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "npc")
        {
            if (Input.GetKey("e"))
            {
                gamemanager.npcval += 1;
                interacttxt.enabled = true;
            }
        }
        else if (other.tag == "exit")
        {
            Debug.Log("clothes: " + gamemanager.clothesval + ", resume: " + gamemanager.resumeval + ", pants: " + gamemanager.pantval);
            int score = gamemanager.clothesval + gamemanager.resumeval + gamemanager.pantval;
            if (Input.GetKey("e"))
            {
                if (score == 7)
                {
                    SceneManager.LoadScene("interviewwin");
                }
                else
                if (score < 7)
                {
                    SceneManager.LoadScene("Interviewlose");
                }
            }
        }
    }


    private void OnTriggerExit2D(Collider2D other)
    {
        interacttxt.enabled = false;
        interat = false;
    }

    void whatever()
    {
        if (interat == true && Input.GetButtonDown("Interact"))
        {
            SceneManager.LoadScene(0);
        }
    }
}
