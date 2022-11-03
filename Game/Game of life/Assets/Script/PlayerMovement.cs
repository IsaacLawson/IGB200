using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed = 5;
    //icon change
    public GameObject leftside;
    public GameObject front;
    public GameObject back;
    public GameObject rightside;
    private bool up;
    private bool down;
    private bool right;
    private bool left;
    private bool collide;

    [SerializeField] private AudioSource Footstep3;
    [SerializeField] private AudioSource Footstep2;

    void Start()
    {
        left = true;
        right = true;
        down = true;
        up = true;
        collide = false;
     }

    void Update()
    {
        if (!collide)
        {
            left = true;
            right = true;
            down = true;
            up = true;
        }
        if (Input.GetKey(KeyCode.D)&& right)
        {
            //When the D key is clicked, the player will move to the right
            
            transform.position += Vector3.right * moveSpeed * Time.deltaTime;
            Footstep3.Play();
            //icon change
            leftside.SetActive(false);
            rightside.SetActive(true);
            front.SetActive(false);
            back.SetActive(false);
            
        }
        else if (Input.GetKey(KeyCode.A)&& left)
        {
            //When the A key is clicked, the player will begin moving to the left 
            transform.position += Vector3.right * -moveSpeed * Time.deltaTime;
            Footstep3.Play();
            //icon change
            leftside.SetActive(true);
            rightside.SetActive(false);
            front.SetActive(false);
            back.SetActive(false);
        }
        else if (Input.GetKey(KeyCode.W)&& up)
        {
            //When the W key is clicked, the player will begin moving forewards
            transform.position += Vector3.up * moveSpeed * Time.deltaTime;
            Footstep2.Play();
            //icon change
            leftside.SetActive(false);
            rightside.SetActive(false);
            front.SetActive(false);
            back.SetActive(true);
        }
        else if (Input.GetKey(KeyCode.S)&& down)
        {
            //When the S key is Clicked, the player will begin moving backwards
            transform.position += Vector3.up * -moveSpeed * Time.deltaTime;
            Footstep2.Play();
            //icon change
            leftside.SetActive(false);
            rightside.SetActive(false);
            front.SetActive(true);
            back.SetActive(false);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        collide = true;
        if (collision.tag == "Wall")
        {

        }
        if (collision.tag == "TWall")
        {
            up = false;
        }
        else
        {
            up = true;
        }
        if (collision.tag == "DWall")
        {
            down = false;
        }
        else
        {
            down = true;
        }
        if (collision.tag == "LWall")
        {
            left = false;
        }
        else
            left = true;
        if (collision.tag == "RWall")
        {
            right = false;
        }
        else
            right = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        collide = false;
    }
}
