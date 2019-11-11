using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class StateData : ScriptableObject
{
    public abstract void OnEnter(CharacterStateBase characterState, Animator animator, AnimatorStateInfo stateInfo);

    //each state should update based on the pre-defined cards
    public abstract void UpdateAbility(CharacterStateBase characterStateBase, Animator animator, AnimatorStateInfo stateInfo);

    public abstract void OnExit(CharacterStateBase characterState, Animator animator, AnimatorStateInfo stateInfo);
}

