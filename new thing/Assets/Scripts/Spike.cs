using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike : MonoBehaviour {

	public static int healthValue;
	
	void OnTriggerEnter2D(Collider2D other){
		if(other.tag == "Player"){
			print("Ouch! you've hit a spike!");
			
			HealthManager.RemoveHealth(healthValue);
}
