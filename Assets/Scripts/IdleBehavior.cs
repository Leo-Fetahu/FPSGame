using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class IdleBehavior : StateMachineBehaviour
{
    float timer;
    Transform player;
    float chaseRange = 50;
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        timer = 0;
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // OnStateEnter is called on each Update frame between OnStateEnter and OnStateExit Callbacks
    public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        timer += Time.deltaTime;
        if (timer > 5)
            animator.SetBool("isPatrolling", true);

        float distance = Vector3.Distance(animator.transform.position, player.position);
        if (distance < chaseRange)
            animator.SetBool("isChasing", true);
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        
    }
}
