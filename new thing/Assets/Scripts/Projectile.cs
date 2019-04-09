using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {

	public float speed;

	public float timeOut;

	public GameObject player;

	public GameObject enemyFaint;

	public GameObject projectileParticle;

	public int pointsForKill;

	// Use this for initialization
	void Start () {
		player = GameObject.Find("Player");

		enemyFaint = Resources.Load("Prefabs/Faint_PS") as GameObject;

		projectileParticle = Resources.Load("Prefabs/Respawn_PS") as GameObject;

		if(player.transform.localScale.x <0){
			speed = -speed;
		}

		//destroys projectile after x seconds
		Destroy(gameObject,timeOut);

	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Rigidbody2D>().velocity = new Vector2(speed, GetComponent<Rigidbody2D>().velocity.y);
	}

	void OnTriggerEnter2D(Collider2D other){
		//destroys enemy on contact with projectile. add points
		if(other.tag == "Enemy"){
			Instantiate(enemyFaint, other.transform.position, other.transform.rotation);
			Destroy (other.gameObject);
			ScoreManager.AddPoints (pointsForKill);
		}

		// Instantiate(ProjectileParticle, transform.position, transform.rotation);

		//Destroy projectile after hitting the enemy.
		Destroy (gameObject, timeOut);
	}

	void OnCollisionEnter2D(Collision2D other){
	
	Instantiate(projectileParticle, transform.position, transform.rotation);
	Destroy (gameObject);

	}
}
