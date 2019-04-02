using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class HealthManager : MonoBehaviour {

	public static int health;

	//if you want the variable prublic then you must put it as public
	//defaults to private
	Text healthCounter;

	// Use this for initialization
	void Start () {
		//data UI Text component
		//modify the parent (score counter) to modify the child (score amount)
		healthCounter = GetComponent<Text>();

		health = 0;
		
	}
	
	// Update is called once per frame
	void Update () {

		// single line (line 27) makes it so braces arent needed
		//you can put in braces if you want 
		if (health < 10)
			health = 10;

		//this makes a string 
		healthCounter.text = " " + health;

		if (health > 10)
			health = 10;
	}
	

	// static means it cant change. accessing this from another script to change the score
	public static void AddHealth (int healthToAdd) {
		//adds the points to the score so put the plus before = to add new points not replace old points
		health += healthToAdd;

		//score = score + pointsToAdd;  <-longhand 

	//public static void Reset () {
	// Scored;
	//}
	}
}

