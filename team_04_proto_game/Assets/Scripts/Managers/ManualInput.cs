using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManualInput : MonoBehaviour
{
    private AliController aliController;

    private void Awake()
    {
        aliController = this.gameObject.GetComponent<AliController>();
    }

    private void Update()
    {
        if (VirtualInputManager.Instance.MoveRight)
        {
            aliController.MoveRight = true;
        }
        else
        {
            aliController.MoveRight = false;
        }

        if (VirtualInputManager.Instance.MoveLeft)
        {
            aliController.MoveLeft = true;
        }
        else
        {
            aliController.MoveLeft = false;
        }

        if (VirtualInputManager.Instance.Jump)
        {
            aliController.Jump = true;
        }
        else
        {
            aliController.Jump = false;
        }
    }
}
