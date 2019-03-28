using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickups : MonoBehaviour {

	public int healthValue;

	void OnTriggerEnter2D (Collider2D other){
		if(other.tag == "Player"){

			print("You recieve one more life!");

			// HealthBar.AddPoints int healthValue;

			Destroy(gameObject);

		}

	}
}
