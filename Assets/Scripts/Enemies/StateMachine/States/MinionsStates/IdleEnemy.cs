using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class IdleEnemy : StateMachineBehaviour
{
    public const string transitionParameter = "State";
    NavMeshAgent navAgent; 
    public float minWanderDistance = 3;
    public float maxWanderDistance = 8;
    public float walkSpeed = 1;
    public Detection detection;

    public override void OnStateEnter(Animator animator, AnimatorStateInfo animatorStateInfo, int layerIndex) 
    {
        if (detection == null)
            detection = animator.GetComponent<Detection>();
        if (navAgent == null)
            navAgent = animator.GetComponent<NavMeshAgent>();
        
        navAgent.ResetPath();
        navAgent.speed = walkSpeed;
    }

    public override void OnStateUpdate(Animator animator, AnimatorStateInfo animatorStateInfo, int layerIndex) 
    {
        if (ChaseEnemy.ShouldChasePlayer(animator.transform.position) && detection.DetectionMechanic())
            animator.SetInteger(transitionParameter, (int) Transition.CHASE);
        else
        {
            if (navAgent.hasPath)
                animator.SetInteger(transitionParameter, (int) Transition.WANDER);
            else
                SetRandomDestination(navAgent);
        }    
    }

    public void SetRandomDestination(NavMeshAgent _agent)
    {
        float radius = Random.Range(minWanderDistance, maxWanderDistance);
        Vector3 randomPosition = Random.insideUnitSphere * radius;
        randomPosition += _agent.transform.position;
        NavMeshHit hit;

        if (NavMesh.SamplePosition(randomPosition, out hit, radius, 1))
            _agent.SetDestination(hit.position);
    }
}
