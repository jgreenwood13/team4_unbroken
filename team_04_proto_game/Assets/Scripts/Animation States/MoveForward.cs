using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New State", menuName = "AbilityData/MoveForward")]

public class MoveForward : StateData
{
    public float Speed;

    public override void OnEnter(CharacterStateBase characterState, Animator animator, AnimatorStateInfo stateInfo)
    {

    }
    public override void UpdateAbility(CharacterStateBase characterStateBase, Animator animator, AnimatorStateInfo stateInfo)
    {
        AliController control = characterStateBase.GetBotController(animator);

        if (control.MoveRight && control.MoveLeft)
        {
            control.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
            animator.SetBool("IsRunning", false);
            return;
        }

        if (!control.MoveRight && !control.MoveLeft)
        {
            control.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
            animator.SetBool("IsRunning", false);
            return;
        }

        if (control.MoveRight)
        {
            /* DONT NEED TO SWITCH TO RUN (THIS IS RUN SCRIPT), JUST MOVE */
            control.transform.Translate(Vector3.forward * Speed * Time.deltaTime);
            control.transform.rotation = Quaternion.Euler(0f, 90f, 0f);
            //animator.SetBool("IsRunning", true);
        }

        if (control.MoveLeft)
        {
            /* DONT NEED TO SWITCH TO RUN (THIS IS RUN SCRIPT), JUST MOVE */
            control.transform.Translate(Vector3.forward * Speed * Time.deltaTime);
            control.transform.rotation = Quaternion.Euler(0f, -90f, 0f);
            //animator.SetBool("IsRunning", true);
        }
    }

    public override void OnExit(CharacterStateBase characterState, Animator animator, AnimatorStateInfo stateInfo)
    {

    }
}
