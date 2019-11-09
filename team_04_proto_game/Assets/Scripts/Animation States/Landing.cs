using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New State", menuName = "AbilityData/Landing")]

public class Landing : StateData
{
    public override void OnEnter(CharacterStateBase characterState, Animator animator, AnimatorStateInfo stateInfo)
    {
        animator.SetBool("IsJumping", false);
    }

    public override void UpdateAbility(CharacterStateBase characterStateBase, Animator animator, AnimatorStateInfo stateInfo)
    {

    }

    public override void OnExit(CharacterStateBase characterState, Animator animator, AnimatorStateInfo stateInfo)
    {

    }
}
