using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickups : MonoBehaviour {

	public int healthValue;
	
	void OnTriggerEnter2D(Collider2D other){
		if(other.tag == "Player"){

			print("You've collected the health pickup!");

			HealthManager.AddHealth(healthValue);

			Destroy(gameObject);
		}
		
	}

}
	

