using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AliController : MonoBehaviour
{
    private float moveSpeed;
    private Animator animator;
    private float xposition;
    private bool facingRight = true;
    private Vector3 localRotation;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");  //left and right movement
        float vertical = Input.GetAxis("Vertical");  //up and down movement

        //Debug.Log(horizontal);  //writes values to console screen
        Debug.Log(vertical); 
        Vector2 position = transform.position;
        position.x = position.x + 3.0f * horizontal * Time.deltaTime;
        position.y = position.y + 3.0f * vertical * Time.deltaTime;
        transform.position = position;
    }
}
