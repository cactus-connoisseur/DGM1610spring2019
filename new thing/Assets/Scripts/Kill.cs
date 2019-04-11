using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kill : MonoBehaviour {

	public LevelManager levelManager;

	void start() {
		//loading GameObject
		levelManager = FindObjectOfType<LevelManager>();
	}

	void onTriggerEnter2D(Collider2D other){
		if(other.tag == "Player"){
			levelManager.RespawnPlayer();
		}

	}
}
