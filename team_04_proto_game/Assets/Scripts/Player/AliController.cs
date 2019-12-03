using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AliController : MonoBehaviour
{
    public Animator animator;
    public bool MoveRight;
    public bool MoveLeft;
    public bool Jump;
    public GameObject ColliderEdgePrefab; //
    public List<GameObject> BottomSpheres = new List<GameObject>();

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

    
    private void Awake() //
    {
        float zpos = transform.position.z;
        CapsuleCollider2D cap = GetComponent<CapsuleCollider2D>();
        float bottom = cap.bounds.center.y - cap.bounds.extents.y;
        float left = cap.bounds.center.x - (cap.bounds.extents.x)/6;
        float right = cap.bounds.center.x + (cap.bounds.extents.x)/6;

        GameObject bottomCenter = CreateEdgeSphere(new Vector3(0f, bottom, zpos));
        GameObject bottomLeft = CreateEdgeSphere(new Vector3(left, bottom, zpos));
        GameObject bottomRight = CreateEdgeSphere(new Vector3(right, bottom, zpos));

        bottomCenter.transform.parent = this.transform;
        bottomLeft.transform.parent = this.transform;
        bottomRight.transform.parent = this.transform;

        BottomSpheres.Add(bottomCenter);
        BottomSpheres.Add(bottomLeft);
        BottomSpheres.Add(bottomRight);

    }

    public GameObject CreateEdgeSphere(Vector3 pos) //
    {
        GameObject obj = Instantiate(ColliderEdgePrefab, pos, Quaternion.identity);
        return obj;
    }
}
