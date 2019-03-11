using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ScoreManager : MonoBehaviour {
	
	public static int score;

	//if you want the variable prublic then you must put it as public
	//defaults to private
	Text scoreCounter;

	// Use this for initialization
	void Start () {
		//data UI Text component
		//modify the parent (score counter) to modify the child (score amount)
		scoreCounter = GetComponent<Text>();

		score = 0;
		
	}
	
	// Update is called once per frame
	void Update () {

		// single line (line 27) makes it so braces arent needed
		//you can put in braces if you want 
		if (score < 0)
			score = 0;

		//this makes a string 
		scoreCounter.text = " " + score;
	}

	// static means it cant change. accessing this from another script to change the score
	public static void AddPoints (int pointsToAdd) {
		//adds the points to the score so put the plus before = to add new points not replace old points
		score += pointsToAdd;

		//score = score + pointsToAdd;  <-longhand 

	//public static void Reset () {
	// Scored;
	//}
	}
}
