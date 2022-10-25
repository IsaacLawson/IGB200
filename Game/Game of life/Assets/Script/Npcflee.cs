using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Npcflee : MonoBehaviour
{
    private Vector3 direction;
    [HideInInspector] public int speed;
    private float t = 0;
    private void Start()
    {
        speed = 1;
        t = 0;
        direction = ran(direction);
    }
     Vector3 ran(Vector3 ram)
    {
        ram = new Vector3((int) Random.Range(-1, 2), (int)Random.Range(-1, 2),0);
        if (ram.x == 0 && ram.y == 0)
        {
            ram = ran(ram);
        }
        return ram;

    }
    // Update is called once per frame
    void Update()
    {
        Debug.Log(direction);
        t += Time.deltaTime;
        if (t > 5)
        {
            direction = ran(direction);
            t = 0;
        }
        Vector3 pos = gameObject.transform.position;
        pos.x += direction.x * Time.deltaTime * speed;
        pos.y += direction.y * Time.deltaTime * speed;
        gameObject.transform.position = pos;
        




        /*transform.position = Vector2.MoveTowards(transform.position,positions[index], Time.deltaTime * speed);

        if (transform.position == positions[index])
        {
            if (index == positions.Length -1)
            {
                index = 0;
            }
            else
            {
                index++;
            }
        }*/
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "TWall")
        {
            direction.y = -1;
        }
        if (collision.tag == "RWall")
        {
            direction.x = -1;
        }
        if (collision.tag == "LWall")
        {
            direction.x = 1;
        }
        if (collision.tag == "DWall")
        {
            direction.y = 1;
        }
        if (collision.tag == "Wall")
        {
            direction.x *= -1;
            direction.y *= -1;
        }
    }
}
