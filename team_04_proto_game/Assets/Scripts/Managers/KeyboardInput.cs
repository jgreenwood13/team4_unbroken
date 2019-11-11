using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardInput : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKey(KeyCode.D) || (Input.GetKey(KeyCode.RightArrow)))
        {
            print("Right Key");
            VirtualInputManager.Instance.MoveRight = true;
        }
        else
        {
            VirtualInputManager.Instance.MoveRight = false;
        }

        if (Input.GetKey(KeyCode.A) || (Input.GetKey(KeyCode.LeftArrow)))
        {
            print("Left Key");
            VirtualInputManager.Instance.MoveLeft = true;
        }
        else
        {
            VirtualInputManager.Instance.MoveLeft = false;
        }

        if (Input.GetKey(KeyCode.Space))
        {
            print("Space Key");
            VirtualInputManager.Instance.Jump = true;
        }
        else
        {
            VirtualInputManager.Instance.Jump = false;
        }
    }
  
}
