using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStateBase : StateMachineBehaviour
{
    public List<StateData> ListAbilityData = new List<StateData>();

    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        foreach (StateData d in ListAbilityData)
        {
            d.OnEnter(this, animator, stateInfo);
        }
    }

    // To update all cards
    public void UpdateAll(CharacterStateBase characterStateBase, Animator animator, AnimatorStateInfo stateInfo)
    {
        foreach (StateData d in ListAbilityData)
        {
            d.UpdateAbility(characterStateBase, animator, stateInfo);
        }
    }

    // update all for each frame
    public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        UpdateAll(this, animator, stateInfo);
    }

    public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        foreach (StateData d in ListAbilityData)
        {
            d.OnExit(this, animator, stateInfo);
        }
    }

    /* every state should be able to access bot controller */
    private AliController aliController;

    public AliController GetBotController(Animator animator)
    {
        /* only want to do this once so return controller if not null */
        if (aliController == null)
        {
            aliController = animator.GetComponentInParent<AliController>();

        }
        return aliController;
    }
}
