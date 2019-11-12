using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New State", menuName = "AbilityData/ForceTransitions")]

public class ForceTransitions : StateData
{
    [Range(0.01f, 1f)]
    public float TransitionTiming;

    public override void OnEnter(CharacterStateBase characterState, Animator animator, AnimatorStateInfo stateInfo)
    {

    }
    public override void UpdateAbility(CharacterStateBase characterStateBase, Animator animator, AnimatorStateInfo stateInfo)
    {
        if (stateInfo.normalizedTime >= TransitionTiming)
        {
            animator.SetBool("ForceTransitions", true);
        }
    }

    public override void OnExit(CharacterStateBase characterStateBase, Animator animator, AnimatorStateInfo stateInfo)
    {
        animator.SetBool("ForceTransitions", false);
    }
}
