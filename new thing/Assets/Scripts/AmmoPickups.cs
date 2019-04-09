using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPickups : MonoBehaviour {

	public bool ammo;

	void OnTriggerEnter2D (Collider2D other){
		if(other.tag == "Player"){

			print("You've collected ammo!");

			// ScoreManager.AddPoints(coinValue);

			Destroy(gameObject);

		}

	}

}
