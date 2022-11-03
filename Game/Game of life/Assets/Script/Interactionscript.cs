using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

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

    public Image formalshirtsprite;
    public Image casualshirtsprite;
    public Image casualpantsprite;
    public Image formalpantsprite;
    public Image goodresumesprite;
    public Image newsresumesprite;
    public Image badresumesprite;


    // Start is called before the first frame update
    void Start()
    {
        interacttxt.enabled = false;
        interat = false;

        formalshirtsprite.enabled = false;
        casualshirtsprite.enabled = false;
        casualpantsprite.enabled = false;
        formalpantsprite.enabled = false;
        goodresumesprite.enabled = false;
        newsresumesprite.enabled = false;
        badresumesprite.enabled = false;
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


                casualshirtsprite.enabled = true;
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

                formalshirtsprite.enabled = true;
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

                casualpantsprite.enabled = true;
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

                formalpantsprite.enabled = true;
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

                badresumesprite.enabled = true;
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

                newsresumesprite.enabled = true;
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

                goodresumesprite.enabled = true;
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