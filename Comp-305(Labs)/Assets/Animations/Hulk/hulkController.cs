using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hulkController : MonoBehaviour {
    public float maxSpeed = 10.0f;
    public float jumpForce = 200;
    public Transform groundCheck;
    public LayerMask defineGround;


    private Rigidbody2D rbody;
    private SpriteRenderer sRend;
    private Animator animator;

    private float groundChceckRadius = 0.2f;
    private bool isGrounded = false;

    // Use this for initialization
    void Start() {
        rbody = GetComponent<Rigidbody2D>();
        sRend = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetAxis("Jump3") > 0 && isGrounded)
        {
            animator.SetBool("Ground", false);
            rbody.AddForce(new Vector2(0, jumpForce));
        }
    }

        private void FixedUpdate()
        {

            isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundChceckRadius, defineGround);

            Physics2D.OverlapCircle(groundCheck.position, groundChceckRadius, defineGround);

            animator.SetBool("Ground", isGrounded);
            animator.SetFloat("vSpeed", rbody.velocity.y);


            float moveHorizontal = Input.GetAxis("Horizontal3");

            animator.SetFloat("Speed", Mathf.Abs(moveHorizontal));

            rbody.velocity = new Vector2(moveHorizontal * maxSpeed, rbody
                .velocity.y);

            if (moveHorizontal > 0)
            {

                sRend.flipX = false;
            }
            else if (moveHorizontal < 0)
            {
                sRend.flipX = true;
            }
        }
    }

