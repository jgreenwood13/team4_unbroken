using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirtualInputManager : Singleton<VirtualInputManager>
{
    /*public static VirtualInputManager Instance = null;
    private void Awake()
    {
        //gameobject will be only virtual input manager
        if (Instance == null)
        {
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(this.gameObject);
        }
    }*/

    public bool MoveRight;
    public bool MoveLeft;
    public bool Jump;
}
