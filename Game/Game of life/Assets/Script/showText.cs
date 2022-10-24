using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class showText : MonoBehaviour
{


    public TMP_Text interacttxt;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        interacttxt.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter2D(Collider2D player)
    {
        interacttxt.enabled = true;

    }


private void OnTriggerExit2D(Collider2D player)
    {
        interacttxt.enabled = false;
         
    }
}

