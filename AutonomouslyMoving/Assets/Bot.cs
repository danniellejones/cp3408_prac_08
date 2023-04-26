using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;

public class Bot : MonoBehaviour
{
    NavMeshAgent agent;
    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        agent = this.GetComponent<NavMeshAgent>();
    }

    void Seek(Vector3 location)
    {
        // The location is the cop
        agent.SetDestination(location);
    }

    void Flee(Vector3 location)
    {
        Vector3 fleeVector = location - this.transform.position;
        agent.SetDestination(this.transform.position - fleeVector);
    }

    // Update is called once per frame
    void Update()
    {
        // Seek(target.transform.position);
        Flee(target.transform.position);
       
    }
}
