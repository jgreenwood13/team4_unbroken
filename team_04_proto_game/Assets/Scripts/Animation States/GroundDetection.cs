using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New State", menuName = "AbilityData/GroundDetection")]

public class GroundDetection : StateData
{
    public float Distance;
    public override void OnEnter(CharacterStateBase characterState, Animator animator, AnimatorStateInfo stateInfo)
    {
        
    }

    public override void UpdateAbility(CharacterStateBase characterStateBase, Animator animator, AnimatorStateInfo stateInfo)
    {
        AliController ali = characterStateBase.GetBotController(animator);

        if (IsGrounded(ali))
        {
            animator.SetBool("IsGrounded", true);
        }
        else
        {
            animator.SetBool("IsGrounded", false);
        }
    }

    public override void OnExit(CharacterStateBase characterState, Animator animator, AnimatorStateInfo stateInfo)
    {

    }

    bool IsGrounded(AliController ali)
    {
        if (ali.RIGID_BODY.velocity.y > -0.01 && ali.RIGID_BODY.velocity.y <= 0)
        {
            return true;
        }
        foreach(GameObject o in ali.BottomSpheres)
        {
            //Debug.DrawRay(o.transform.position, -Vector3.up * 0.7f, Color.yellow);
            RaycastHit hit;
            if (Physics.Raycast(o.transform.position, -Vector3.up, out hit, Distance))
            {
                return true;
            }
        }
        return false;
    }
}
