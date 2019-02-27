using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Practice_Else_Ifs : MonoBehaviour {

	public string skittlesColor;
	public bool isSour = true;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(skittlesColor == "Dark red" || skittlesColor == "Maroon"){
			if(isSour){
				print("This is sour cherry flavor.");
			}
			else{
				print("This is sweet cherry flavor.");
			}
		}
		else if(skittlesColor == "Blue"){
			if(isSour){
				print("This is sour blueberry flavor.");
			}
			else{
				print("This is sweet blueberry flavor.");
			}
		}
		else if(skittlesColor == "Green" || skittlesColor == "Dark green"){
			if(isSour){
				print("This is sour green apple flavored.");
			}
			else{
				print("this is green apple flavored.");
			}
		}
		else if(skittlesColor == "Purple" || skittlesColor == "Plum"){
			if(isSour){
				print("This is sour grape flavored.");
			}
			else{
				print("This is regular grape flavor.");
			}
		}
		else if(skittlesColor == "Yellow"){
			if(isSour){
				print("This is the flavor of satan.");
			}
			else{
				print("This is the flavor of satan.");
			}
		}
		else if(skittlesColor == "Brown"){
			print("I think you might have a MNM there.");
		}
		else if(skittlesColor == "Orange"){
			if(isSour){
				print("Is there really a sour version of orange?");
			}
			else{
				print("Just regular orange flavor.");
			}
		}
		else if(skittlesColor == "Lime green"){
			if(isSour){
				print("This is sour lime flavor.");
			}
			else{
				print("Is there really a flavor of lime that isn't sour?");
			}
		}
		else if(skittlesColor == "Pink"){
			print("I think you might have a starburst right there.");
		}
		else if(skittlesColor == "Rainbow"){
			if(isSour){
				print("Dude I have no idea what this flavor is.. you're on your own.. especially if its sour. Good luck.");
			}
			else{
				print("Dude I have no idea what this flavor is.. you're on your own... Good luck.");
			}
		}
		else{
			print("Yeaah, what you're eating aren't Skittles.");
		}
	}	
}
