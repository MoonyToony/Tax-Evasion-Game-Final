using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EvenSimplerAi : MonoBehaviour
{
    public GameObject player;
    public NavMeshAgent _agent;

    // Update is called once per frame
    void Update()
    {
        player = GameObject.Find("XR Rig");
        // distance = Vector3.Distance(player.transform.position, this.transform.position);
        _agent.SetDestination(player.transform.position);
    }
}
