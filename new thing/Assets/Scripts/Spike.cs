using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike : MonoBehaviour {

	public int damage;
	public HealthManager healthManager;

	void Start (){
		healthManager = FindObjectOfType <HealthManager>();
	}

	
	void OnTriggerEnter2D(Collider2D other){
		if(other.tag == "Player"){
			
			healthManager.SubtractHealth(damage);

			print("Ouch! you've hit a spike!");
		}
	}
}
