using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class HealthBar : MonoBehaviour {

	private int maxHealth = 100;
	public int HealthCounter;
	public int currentHealth;
	public int healthToAdd;

	Text HealthText;

	// Use this for initialization
	void Start () {
		//Sets HP to 100 at the start of the game
		HealthCounter = 100;
		//makes the current HP equal to 100
		currentHealth = HealthCounter;
		//Sends info to text UI within Unity
		HealthText = GetComponent<Text>();
		//Concats the " " plus the value of the current HP
		HealthText.text = " " + currentHealth;
		
	}
	// public void AddHealth (int healthToAdd) {
	// 	//adds the points to the score so put the plus before = to add new points not replace old points
	// 	HealthText += healthToAdd;
	}
	
	// Update is called once per frame
	void Update () {

	}
		
	public void DamageDealt(int damage){
		//Same as currentHP = currentHP - damage
		currentHealth -= damage;
		//Once HP reaches 0 then it's game over.
		if(currentHealth<=0){
			currentHealth = 0;
			print("You're dead, Game Over.");
		}
	}
}
