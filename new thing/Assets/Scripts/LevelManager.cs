using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

public GameObject currentCheckPoint;


public GameObject player;
private Rigidbody2D pcRigid;

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
	
		//player = GameObject.Find("Player");
		
		
		pcRigid = player.GetComponent<Rigidbody2D>();
	}

	public void RespawnPlayer(){
		StartCoroutine ("RespawnPlayerCo");
	}

	public IEnumerator RespawnPlayerCo(){
		//generate death particle
		Instantiate (deathParticle, pcRigid.transform.position, pcRigid.transform.rotation);
		//hide PC
		player.SetActive(false);
		player.GetComponent<Renderer> ().enabled = false;
		// gravity reset
		gravityStore = pcRigid.GetComponent<Rigidbody2D>().gravityScale;
		pcRigid.GetComponent<Rigidbody2D>().gravityScale = 0f;
		pcRigid.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
		//point penalty
		ScoreManager.AddPoints(-pointPenaltyOnDeath);
		//debug message
		Debug.Log ("Player Respawn");
		//respawn delay
		yield return new WaitForSeconds (respawnDelay);
		//gravity restore
		pcRigid.GetComponent<Rigidbody2D>().gravityScale = gravityStore;
		//match pcs transform position
		player.transform.position = currentCheckPoint.transform.position;
		//show pc
		//PC.enabled = true;
		player.SetActive(true);
		player.GetComponent<Renderer> ().enabled = true;
		//spawn pc
		Instantiate (respawnParticle, currentCheckPoint.transform.position, currentCheckPoint.transform.rotation);


	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
