using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Practice_Switch : MonoBehaviour {
	public string leafShape;

	// Use this for initialization
	void Start () {
		PlantType(leafShape);
	}
	
	// Update is called once per frame
	void PlantType (string leaf) {
		switch(leaf){
			case "Linear":
				print("This could be a grass blade.");
			break;
			case "Oval":
				print("This could be an Elm tree.");
			break;
			case "Oblong":
				print("This could be a Magnolia tree.");
			break;
			case "Ovate":
				print("This could be a Hackberry tree.");
			break;
			case "Obovate":
				print("This could be Witch-hazel.");
			break;
			case "Deltiod":
				print("This could be a an Eastern Cottonwood tree.");
			break;
			case "Heart":
				print("This could be a Linden tree.");
			break;
			case "Elliptical":
				print("This could be a Cherry tree.");
			break;
			case "Lanceolate":
				print("This could be a Willow tree.");
			break;
			default:
				print("I'm not familiar with " +leafShape+".");
			break;

		}
		
	}
}
