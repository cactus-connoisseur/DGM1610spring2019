using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCharacter : MonoBehaviour
{
		// Player movement variables
        public float moveSpeed; 
        public float jumpHeight;
		private bool doubleJump;

		// Player grounded variables
		private bool grounded;
		public Transform groundCheck;
		public float groundCheckRadius;
		public LayerMask whatIsGround;

		//Non-slide Player
		private float moveVelocity;

		public Animator animator;

        // Use this for initialization
	    void Start () {
					//Default to true on grounded
				animator=gameObject.GetComponent<Animator>();
				// animation reset
				animator.SetBool("isWalking",false);
				animator.SetBool("jumping",false);
			

	    }

		void FixedUpdate(){
			grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
		}
			
			 // NOTES:
			 // this && that (this and that)
			 // this || that (this or that)
			 // !Not this

	 // Update is called once per frame
	void Update () {

		//non slide player
		moveVelocity = 0f;

		// Moves player left and right with ket a and key d
		 if(Input.GetKey(KeyCode.D))
		 {
			//  GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
			moveVelocity = moveSpeed;
			 animator.SetBool("isWalking",true);
		}
			else if(Input.GetKeyUp (KeyCode.D))
			{
			animator.SetBool("isWalking",false);
			}
		 if(Input.GetKey(KeyCode.A))
		 {
			 //GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
			 moveVelocity = -moveSpeed;
			 animator.SetBool("isWalking",true);
		 }
		 else if(Input.GetKeyUp (KeyCode.A))
		 {
			 animator.SetBool("isWalking",false);
		 }

		 //tjis is outside of the conditionals so runs constantly
		 GetComponent<Rigidbody2D>().velocity = new Vector2(moveVelocity, GetComponent<Rigidbody2D>().velocity.y);

		// Makes player jump when w key is hit
        if(Input.GetKeyDown(KeyCode.W)){
				if(grounded)
					{
					animator.SetBool("jumping",true);
					Jump();
					doubleJump = true;
					}
				else if (doubleJump)
					{
						Jump();
						doubleJump = false;
						// animator.SetBool("isDoubleJumping",true);
					}
			}
		//double jump code
			if(grounded)
			{
				doubleJump = false;
				animator.SetBool("jumping",false);
			}

			

		//player flip when moving left to right
		if (GetComponent<Rigidbody2D>().velocity.x > 0)
			transform.localScale = new Vector3(0.1f,0.1f,1f);

		else if (GetComponent<Rigidbody2D>().velocity.x < 0)
			transform.localScale = new Vector3(-0.1f,0.1f,1f);

			


	 }

	 public void Jump(){
		//animator.Play
		animator.SetBool("jumping",true);
 		GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x,jumpHeight);
		
		
	 }
}
