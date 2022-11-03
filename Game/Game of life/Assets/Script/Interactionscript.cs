using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;

public class Interactionscript : MonoBehaviour
{
    public TMP_Text interacttxt;
    public GameObject other;
    public GameObject formalshirt;
    public GameObject casualshirt;
    public GameObject casualpant;
    public GameObject formalpant;
    public GameObject goodresume;
    public GameObject newsresume;
    public GameObject badresume;
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
        if (other.tag == "casualshirt")
        {
            if (Input.GetKey("e"))
            {
                gamemanager.clothesval = 1;
                interacttxt.enabled = true;
                formalshirt.SetActive(false);
                casualshirt.SetActive(false);
            }
        }
        else if (other.tag == "formalshirt")
        {
            if (Input.GetKey("e"))
            {
                gamemanager.clothesval = 2;
                Debug.Log(other.gameObject.tag);
                interacttxt.enabled = true;
                casualshirt.SetActive(false);
                formalshirt.SetActive(false);
            }
        }
        else if (other.tag == "casualpant")
        {
            if (Input.GetKey("e"))
            {
                gamemanager.pantval = 1;
                Debug.Log(other.gameObject.tag);
                interacttxt.enabled = true;
                formalpant.SetActive(false);
                casualpant.SetActive(false);
            }
        }
        else if (other.tag == "formalpant")
        {
            if (Input.GetKey("e"))
            {
                gamemanager.pantval = 2;
                Debug.Log(other.gameObject.tag);
                interacttxt.enabled = true;
                casualpant.SetActive(false);
                formalpant.SetActive(false);
            }
        }
        else if (other.tag == "badresume")
        {
            if (Input.GetKey("e"))
            {
                gamemanager.resumeval = 1;
                Debug.Log(other.gameObject.tag);
                interacttxt.enabled = true;
                newsresume.SetActive(false);
                goodresume.SetActive(false);
                badresume.SetActive(false);
            }
        }
        else if (other.tag == "newsresume")
        {
            if (Input.GetKey("e"))
            {
                gamemanager.resumeval = 2;
                Debug.Log(other.gameObject.tag);
                interacttxt.enabled = true;
                goodresume.SetActive(false);
                badresume.SetActive(false);
                newsresume.SetActive(false);
            }
        }
        else if (other.tag == "goodresume")
        {
            if (Input.GetKey("e"))
            {
                gamemanager.resumeval = 3;
                Debug.Log(other.gameObject.tag);
                interacttxt.enabled = true;
                badresume.SetActive(false);
                newsresume.SetActive(false);
                goodresume.SetActive(false);
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