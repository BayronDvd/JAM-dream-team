using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AttackEnemy : StateMachineBehaviour
{
    NavMeshAgent navAgent;
    PlayerSingleton target;
    public static float minAttackDistance = 2;
    public float walkSpeed = 0;
    public float fovAngle = 60;
    public float fovDistance = 10; // To review
    internal Vector3 lastKnownPosition = Vector3.zero;
    public override void OnStateEnter(Animator animator, AnimatorStateInfo animatorStateInfo, int layerIndex) 
    {
        if (navAgent == null)
            navAgent = animator.GetComponent<NavMeshAgent>();
        if (target == null)
            target = PlayerSingleton.GetInstance();

        navAgent.ResetPath();
        // navAgent.speed = walkSpeed;
        navAgent.isStopped = true;
    }

    public override void OnStateUpdate(Animator animator, AnimatorStateInfo animatorStateInfo, int layerIndex) 
    {
        if (!ShouldAttackPlayer(animator.transform.position))
            animator.SetInteger(IdleEnemy.transitionParameter, (int) Transition.CHASE);
        int data = animator.GetComponent<AIComponent>().enemyBehavior.BaseDamage;
        Debug.Log($"Attacking with {data}");
        // Add attack functionality
    }

    public static bool ShouldAttackPlayer(Vector3 attackerPosition)
    {
        PlayerSingleton player = PlayerSingleton.GetInstance();

        return (attackerPosition - player.transform.position).sqrMagnitude <= minAttackDistance * minAttackDistance;
    }


}
