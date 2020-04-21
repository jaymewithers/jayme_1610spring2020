﻿using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class NavAgentBehaviorPractice : MonoBehaviour
{
    private NavMeshAgent agent;
    public Transform player;
    public float speed = 8f;
    private Transform currentDestination;
    private int i;
    public bool canHunt;

    public List<Transform> patrolPoints;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.speed = speed;
        currentDestination = transform;
    }

    private void OnTriggerEnter(Collider other)
    {
        canHunt = true;
        currentDestination = player;
    }

    private void OnTriggerExit(Collider other)
    {
        canHunt = false;
        currentDestination = transform;
    }


    void Update()
    {
        transform.LookAt(agent.steeringTarget);
        if (canHunt)
        {
            agent.destination = currentDestination.position;
            return;
        }

        if (!agent.pathPending && agent.remainingDistance < 0.5f)
        {
            agent.destination = patrolPoints[i].position;
            i = (i + 1) % patrolPoints.Count;
        }
    }
}