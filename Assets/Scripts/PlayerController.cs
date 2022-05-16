using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Vector3 gravity;
    public Vector3 jumpSpeed;
    private bool isGrounded;
    private Rigidbody rb;
    public Animator animator;
    void Awake()
    {
        Physics.gravity = gravity;
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.anyKeyDown && isGrounded) 
        {
            animator.SetBool("IsJumping", true);
            rb.velocity = jumpSpeed;
            isGrounded = false;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        animator.SetBool("IsJumping", false);
        isGrounded = true;
    }
}
