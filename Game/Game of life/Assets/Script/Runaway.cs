using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;



public class Runaway : MonoBehaviour
{
    public GameObject target;
    NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        agent = this.GetComponent<NavMeshAgent>();
    }
    void seek(Vector3 location)
    {
        agent.SetDestination(location);
    }
    // Update is called once per frame
    void Update()
    {
        seek(target.transform.position);
    }
}
