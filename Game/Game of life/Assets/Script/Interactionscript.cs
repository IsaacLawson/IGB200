using System.Collections;
using System.Collections.Generic;
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
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Interactable")
        {
            Debug.Log(other.gameObject.tag);
            interacttxt.enabled = true;

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
            Application.LoadLevel(0);

        }
    }
}