using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike : MonoBehaviour {

	public int damage;
	public HealthManager healthManager;
	public LevelManager levelManager;
	public int health;
	

	
	public GameObject touchedSpike;

	void Start (){
		healthManager = FindObjectOfType <HealthManager>();
		levelManager = FindObjectOfType<LevelManager>();

		

	
	}

	void Update (){
		

		health = HealthManager.health;
		
		

		if(health == 0){
			levelManager.RespawnPlayer();

			
		}
	}
	
	void OnTriggerEnter2D(Collider2D other){
		if(other.tag == "Player"){
			
			healthManager.SubtractHealth(damage);
			touchedSpike = Resources.Load("Prefabs.TouchedSpikeParticle") as GameObject;

			print("Ouch! you've hit a spike!");

			
		}

		
	}
}
