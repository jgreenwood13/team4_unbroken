using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New State", menuName = "AbilityData/Idle")]

public class Idle : StateData
{
    public override void OnEnter(CharacterStateBase characterState, Animator animator, AnimatorStateInfo stateInfo)
    {

    }

    public override void UpdateAbility(CharacterStateBase characterStateBase, Animator animator, AnimatorStateInfo stateInfo)
    {
        AliController control = characterStateBase.GetBotController(animator);
        if (control.Jump)
        {
            animator.SetBool("IsJumping", true); //This is where you left off 
        }

        if (control.MoveRight)
        {
            animator.SetBool("IsRunning", true);
        }

        if (control.MoveLeft)
        {
            animator.SetBool("IsRunning", true);
        }
    }

    public override void OnExit(CharacterStateBase characterState, Animator animator, AnimatorStateInfo stateInfo)
    {

    }
}
