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


    void Start()
    {
     
     
     
     
     }

    void Update()
    {

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * moveSpeed * Time.deltaTime;
            //icon change
            leftside.SetActive(false);
            rightside.SetActive(true);
            front.SetActive(false);
            back.SetActive(false);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.right * -moveSpeed * Time.deltaTime;
            //icon change
            leftside.SetActive(true);
            rightside.SetActive(false);
            front.SetActive(false);
            back.SetActive(false);

        }

        else if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.up * moveSpeed * Time.deltaTime;
            //icon change
            leftside.SetActive(false);
            rightside.SetActive(false);
            front.SetActive(false);
            back.SetActive(true);

        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.up * -moveSpeed * Time.deltaTime;
            //icon change
            leftside.SetActive(false);
            rightside.SetActive(false);
            front.SetActive(true);
            back.SetActive(false);

        }
    }
}
