using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New State", menuName = "AbilityData/Jump")]

public class JumpState : StateData
{
    public float JumpForce;
    public override void OnEnter(CharacterStateBase characterState, Animator animator, AnimatorStateInfo stateInfo)
    {
        characterState.GetBotController(animator).RIGID_BODY.AddForce(Vector3.up * JumpForce);
    }

    public override void UpdateAbility(CharacterStateBase characterStateBase, Animator animator, AnimatorStateInfo stateInfo)
    {
       
    }

    public override void OnExit(CharacterStateBase characterState, Animator animator, AnimatorStateInfo stateInfo)
    {

    }
}
