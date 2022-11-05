using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;

public class Interviewgoal : MonoBehaviour
{

    public TMP_Text interacttxt;
    public GameObject other;
    public bool interat;
    // Start is called before the first frame update
    void Start()
    {

    }
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Suitmade1")
        {
            if (Input.GetKey("e"))
            {
                gamemanager.clothesval = 3;
                gamemanager.resumeval = 3;
                gamemanager.pantval = 3;
                interacttxt.enabled = true;
                SceneManager.LoadScene("End");
            }
        }
        // Update is called once per frame
        void Update()
        {

        }
    }
}
