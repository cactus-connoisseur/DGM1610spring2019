using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

public GameObject currentCheckPoint;
private Rigidbody2D pcRigid;

private GameObject player;

//particles
public GameObject deathParticle;
public GameObject respawnParticle;

//respawn delay
public float respawnDelay;


//point penalty on death
public int pointPenaltyOnDeath;


//store gravity value
private float gravityStore;


	// Use this for initialization
	void Start () {
		pcRigid = GameObject.Find("Player").GetComponent<Rigidbody2D>();
		player = GameObject.Find("Player");
	}

	// public void respawnPlayer(){
	// 	startCorountine ("RespawnPlayerCo");
	// }
	
	// Update is called once per frame
	void Update () {
		
	}
}
