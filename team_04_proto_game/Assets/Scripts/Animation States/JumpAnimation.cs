﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpAnimation : CharacterStateBase
{
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (VirtualInputManager.Instance.Jump)
        {
            //GetBotController(animator).transform.rotation = Quaternion.Euler(0f, 180f, 0f);
            animator.SetBool("IsJumping", true);
            return;
        }
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.SetBool("IsJumping", false);
        return;
    }
}