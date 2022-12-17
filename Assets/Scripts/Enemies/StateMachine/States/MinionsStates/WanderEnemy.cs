using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class WanderEnemy : StateMachineBehaviour
{
    public Detection detection;
    NavMeshAgent navAgent;
    public override void OnStateEnter(Animator animator, AnimatorStateInfo animatorStateInfo, int layerIndex) 
    {
        if (detection == null)
            detection = animator.GetComponent<Detection>();
        if (navAgent == null)
            navAgent = animator.GetComponent<NavMeshAgent>();
    }
    
    public override void OnStateUpdate(Animator animator, AnimatorStateInfo animatorStateInfo, int layerIndex) 
    {
        if (ChaseEnemy.ShouldChasePlayer(animator.transform.position) && detection.DetectionMechanic())
            animator.SetInteger(IdleEnemy.transitionParameter, (int) Transition.CHASE);
        else if (!navAgent.hasPath)
        {
            animator.SetInteger(IdleEnemy.transitionParameter, (int) Transition.IDLE);
        }
    }
}
