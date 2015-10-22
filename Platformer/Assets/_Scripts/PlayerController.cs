/*
Author: Sri Chatala
File : PlayerController.cs
Created Date: Oct 18,2015
Descriptopn: Player Controller script controll the player gameObjects
Laster Updated: Oct 22,2015
*/
using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public float moveSpeed;
    public float jumpHeight;

    private float moveVelocity;

    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatIsGround;
    private bool grounded;

    private bool doubleJump;

    private Animator animator;
	// Use this for initialization
	void Start () {
       animator =  GetComponent<Animator>();
	}
	
    void FixedUpdate()
    {
        grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
    }

	// Update is called once per frame
	void Update () {
        if (grounded)
            doubleJump = false;
        animator.SetBool("Gounded", grounded);
        if (Input.GetKeyDown(KeyCode.Space) && grounded)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, jumpHeight);
        }
        if (Input.GetKeyDown(KeyCode.Space) && !doubleJump && !grounded)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, jumpHeight);
            doubleJump = true;
        }
        moveVelocity = 0f;
        if (Input.GetKey(KeyCode.D))
        {
            moveVelocity = moveSpeed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            moveVelocity = -moveSpeed;
        }

        GetComponent<Rigidbody2D>().velocity = new Vector2(moveVelocity, GetComponent<Rigidbody2D>().velocity.y);
        animator.SetFloat("Speed", Mathf.Abs(GetComponent<Rigidbody2D>().velocity.x));

        if (GetComponent<Rigidbody2D>().velocity.x > 0)
            transform.localScale = new Vector3(1f, 1f, 1f);
        else if (GetComponent<Rigidbody2D>().velocity.x < 0)
            transform.localScale = new Vector3(-1f, 1f, 1f);

        
    }
}
