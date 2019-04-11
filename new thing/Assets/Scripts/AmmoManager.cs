﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class AmmoManager : MonoBehaviour {

	public static int ammo;

	//if you want the variable prublic then you must put it as public
	//defaults to private
	Text seedAmount;

	// Use this for initialization
	void Start () {
		//data UI Text component
		//modify the parent (score counter) to modify the child (score amount)
		seedAmount = GetComponent<Text>();

		ammo = 0;
		
	}
	
	// Update is called once per frame
	void Update () {

		// single line (line 27) makes it so braces arent needed
		//you can put in braces if you want 
		if (ammo < 0)
			ammo = 5;

		//this makes a string 
		seedAmount.text = " " + ammo;

		if (ammo > 10)
			ammo = 10;
	}
	

	// static means it cant change. accessing this from another script to change the score
	public static void AddAmmo (int seedAmount) {
		//adds the points to the score so put the plus before = to add new points not replace old points
		ammo += seedAmount;

		//score = score + pointsToAdd;  <-longhand 

	//public static void Reset () {
	// Scored;
	//}
	}
}


