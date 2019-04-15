﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCharacter : MonoBehaviour
{
		// Player movement variables
        public float moveSpeed; 
        public float jumpHeight;

		// Player grounded variables
		private bool grounded;
		public Transform groundCheck;
		public float groundCheckRadius;
		public LayerMask whatIsGround;

		public Animator animator;

        // Use this for initialization
	    void Start () {
					//Default to true on grounded

					//animation reset 
					animator.SetBool("isWalking",false);
					animator.SetBool("isJumping",false);

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
		// Moves player left and right
		 if(Input.GetKey(KeyCode.D)){
			 GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
			//  animator.SetBool("isWalking",true);
		}
			else if(Input.GetKeyUp (KeyCode.D)){
				animator.SetBool("isWalking",false);
			}
		 if(Input.GetKey(KeyCode.A)){
			 GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
			//  animator.SetBool("isWalking",true);
		 }
		 else if(Input.GetKeyUp (KeyCode.A)){
			//  animator.SetBool("isWalking",false);
		 }

		// Makes player jump
        if(Input.GetKeyDown(KeyCode.W) && grounded){
            Jump();
        }

		//player flip
		if (GetComponent<Rigidbody2D>().velocity.x > 0)
			transform.localScale = new Vector3(0.1007464f,0.1007464f,0.1007464f);

		else if (GetComponent<Rigidbody2D>().velocity.x < 0)
			transform.localScale = new Vector3(-0.1007464f,0.1007464f,0.1007464f);

			//double jump code
			// if(grounded){
			// 	//doubleJump = false;
			// 	animator.SetBool("isJumping",false);
			// }


	 }

	 public void Jump(){
 		GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x,jumpHeight);
		animator.SetBool("isJumping",true);
	 }
}
