using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dictionaries : MonoBehaviour {

public Hashtable personalDetails = new Hashtable();

	// Use this for initialization
	void Start () {

		personalDetails.Add("firstName", "Greg");
		personalDetails.Add("lastName", "LuKoser");
		personalDetails.Add("gender", "male");
		personalDetails.Add("isMarried", true);
		personalDetails.Add("age", 28);

		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
