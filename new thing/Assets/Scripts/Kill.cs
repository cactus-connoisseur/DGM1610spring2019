﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kill : MonoBehaviour {

	void onTriggerEnter2D(Collider2D other){
		if(other.tag == "Player"){
			Destroy(other);
		}
	}
}
