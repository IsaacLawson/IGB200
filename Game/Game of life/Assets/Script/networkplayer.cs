using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;
public class networkplayer : MonoBehaviour

{
    public TMP_Text interacttxt;
    public GameObject other;
    public bool interat;

    [SerializeField] private Sprite Front;
    [SerializeField] private Sprite Back;

    // Start is called before the first frame update
    void Start()
    {
        //interacttxt.enabled = false;
        interat = false;
    }

    void update()
    {
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Npc")
        {
            if (Input.GetKey("e"))
            {
                if (other.gameObject.GetComponent<SpriteRenderer>().sprite != Front)
                {
                    gamemanager.npcval += 1;
                    other.gameObject.GetComponent<SpriteRenderer>().sprite = Front;
                    other.gameObject.GetComponent<Npcflee>().speed = 0;
                } 
            }
        }








        //When the player press the "E" key near the Npc, they freeze in there current position
        //The player score will increase by 1
        //The NPC sprite will change when the player interact with it
        /*if (other.tag == "Npc")
        {
            Debug.Log("hit");
            if (Input.GetKey("e"))
            {
                gamemanager.npcval += 1;
                //interacttxt.enabled = true;
                leftside.SetActive(false);
                rightside.SetActive(false);
                front.SetActive(true);
                back.SetActive(false);
            }
        }
        else if (other.tag == "npc1")
        {
            if (Input.GetKey("e"))
            {
                gamemanager.npcval += 1;
                interacttxt.enabled = true;
                leftside.SetActive(false);
                rightside.SetActive(false);
                front.SetActive(true);
                back.SetActive(false);
            }
        }
        else if (other.tag == "npc1")
        {
            if (Input.GetKey("e"))
            {
                gamemanager.npcval += 1;
                interacttxt.enabled = true;
                leftside.SetActive(false);
                rightside.SetActive(false);
                front.SetActive(true);
                back.SetActive(false);
            }
        }*/
    }


    private void OnTriggerExit2D(Collider2D other)
    {
        //other.gameObject.GetComponent<SpriteRenderer>().sprite = Back;
        interacttxt.enabled = false;
        interat = false;
    }
}
