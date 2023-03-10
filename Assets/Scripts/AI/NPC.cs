using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPC : MonoBehaviour
{
    public NavMeshAgent agent;
    public AIState currentState;
    protected GameObject[] targets;

    public GameObject target;

    public float agentSpeed;

    public virtual void SetupAI()
    {
        agent = this.GetComponent<NavMeshAgent>();
        FindTargets();
        SetDestination(transform.position);
        agentSpeed = agent.speed;
    }

    /// <summary>
    /// Sets the AI's destination to whatever is passed in.
    /// </summary>
    /// <param name="position">The position to move the AI to.</param>
    public virtual void SetDestination(Vector3 position)
    {
        agent.SetDestination(position);
    }

    public virtual void SetAIState(AIState state)
    {
        agent.isStopped = true;
        currentState = state;
        agent.isStopped = false;
    }

    [ContextMenu("Find Regions")]
    public void FindTargets()
    {
        targets = new GameObject[0];
        targets = GameObject.FindGameObjectsWithTag("Plant");
        Debug.Log(targets.Length);
        if (targets.Length == 0)
        {
            targets = GameObject.FindGameObjectsWithTag("DefencePoint");
        }
        Debug.Log($"Found {targets.Length} targets.");
    }
}

/// <summary>
/// The current state of the AI. This is used in the switch case.
/// More can be added, so it is very expandable
/// </summary>
public enum AIState
{
    Nothing,
    Targetting,
    Attacking,
    Confused
}

