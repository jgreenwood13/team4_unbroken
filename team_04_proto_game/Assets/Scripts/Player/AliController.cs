using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AliController : MonoBehaviour
{
    public float Speed;
    public Animator animator;
    public bool MoveRight;
    public bool MoveLeft;
    public bool Jump;

    private Rigidbody2D rigid;
    public Rigidbody2D RIGID_BODY
    {
        get
        {
            if (rigid == null)
            {
                rigid = GetComponent<Rigidbody2D>();
            }
            return rigid;
        }
    }
}
