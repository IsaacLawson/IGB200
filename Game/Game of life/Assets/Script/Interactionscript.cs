using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;

public class Interactionscript : MonoBehaviour
{
    public TMP_Text interacttxt;
    public GameObject other;
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
        if (other.gameObject.tag == "Interactable")
        {
            if (Input.GetKey("e"))
            {
                gamemanager.clothesval = 3;
                interacttxt.enabled = true;
                SceneManager.LoadScene(2);
            }
        }
        if (other.gameObject.tag == "Interactable1")
        {
            if (Input.GetKey("e"))
            {
                gamemanager.foodval = 1;
                Debug.Log(other.gameObject.tag);
                interacttxt.enabled = true;
                SceneManager.LoadScene(3);
            }
        }
        if (other.gameObject.tag == "Interactable2")
        {
            if (Input.GetKey("e"))
            {
                gamemanager.resumeval = 1;
                Debug.Log(other.gameObject.tag);
                interacttxt.enabled = true;
                SceneManager.LoadScene(4);
            }
        }
        if (other.gameObject.tag == "Interactable3")
        {
            if (Input.GetKey("e"))
            {
                gamemanager.resumeval = 1;
                Debug.Log(other.gameObject.tag);
                interacttxt.enabled = true;
                SceneManager.LoadScene(4);
            }
        }
        if (other.gameObject.tag == "Interactable4")
        {
            if (Input.GetKey("e"))
            {
                gamemanager.resumeval = 1;
                Debug.Log(other.gameObject.tag);
                interacttxt.enabled = true;
                SceneManager.LoadScene(4);
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