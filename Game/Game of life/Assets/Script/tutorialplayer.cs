using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;
public class tutorialplayer : MonoBehaviour
{
    public TMP_Text interacttxt;
    public GameObject other;
    public GameObject tutorialexit;
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
        if (other.tag == "exit")
        {
            if (Input.GetKey("e"))
            {
                interacttxt.enabled = true;
            }
        }
        else if (other.tag == "tutorialexit")
        {
            if (Input.GetKey("e"))
            {
                {
                    SceneManager.LoadScene("heading to uni");
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