﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

// movement variables
public float moveSpeed;
public bool moveRight;

public Vector3 scale;

//wall check
public Transform wallCheck;
public float wallCheckRadius;
public LayerMask whatIsWall;
private bool hittingWall;
public bool isStunned;

//edge check
private bool notAtEdge;
public Transform edgeCheck;


	void Start()
	{
		scale = transform.localScale;
	}
	
	// Update is called once per frame
	void Update () {
		notAtEdge = Physics2D.OverlapCircle(edgeCheck.position, wallCheckRadius, whatIsWall);

		hittingWall = Physics2D.OverlapCircle(wallCheck.position, wallCheckRadius, whatIsWall);

		if (hittingWall || !notAtEdge) {
			moveRight = !moveRight;
		}
		if (moveRight) {
			transform.localScale = new Vector3(-scale.x, scale.y, scale.z);
			GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);

		}

		else {
			transform.localScale = new Vector3(scale.x, scale.y, scale.z);
			GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
		}
	}
	// void Stunned(bool isStunned){
	// 	//use coroutine for the respawn and timer of the enemy respawning
	// 	if(isStunned){
	// 		//gameobject with the rigidbody and box collider
	// 		Destroy (gameObject);
	// 	}
		
	// }
}
