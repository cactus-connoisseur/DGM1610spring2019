using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HwArrayListDict : MonoBehaviour {

//list of people to email
public string email1 = "Danielle";
public string email2 = "Jennifer";
public string email3 = "Gracie";
public string email4 = "Bryan";
public string email5 = "Jeffrey";
public string email6 = "Ashleigh";
public string email7 = "Cyann";
public string email8 = "Anya";

//my array
public string[] emailList = new string[]{"Danielle","Jennifer","Gracie","Bryan","Jeffrey","Ashleigh","Cyann","Anya"};

//my list 
public List<string> catNamesList = new List<string>();

//my arraylist
public ArrayList familyTree = new ArrayList();


	// Use this for initialization
	void Start () {

		//cat names
		catNamesList.Add("Subtle");
		catNamesList.Add("Nonsense");
		catNamesList.Add("Olive");
		catNamesList.Add("Ms. Kitty");
		catNamesList.Add("Lilly");
		catNamesList.Add("VanHorkington");
		catNamesList.Add("Sense");
		catNamesList.Add("Tumma");
		catNamesList.Add("Fluffy");
		catNamesList.Add("Lemonaid");
		catNamesList.Add("Cheeto");
		catNamesList.Add("Kermit");
		catNamesList.Add("Peach");
		catNamesList.Add("Marbles");
		//remove these from the list, they're terrible names 
		catNamesList.Remove("Fluffy");
		catNamesList.Remove("VanHorkington");
		catNamesList.Remove("Sense");

		//father's parents
		familyTree.Add("LeAnn");
		familyTree.Add("Udell");
		//mother's parents
		familyTree.Add("Karen");
		familyTree.Add("Radney");
		//parents (dad,mom)
		familyTree.Add("Garry");
		familyTree.Add("Sarah");
		//children (birth order)
		familyTree.Add("Laurelin");
		familyTree.Add("Montana");
		familyTree.Add("Leia");
		//wants to be adopted
		familyTree.Add("Krystal");
		//changed mind
		familyTree.Remove("Krystal");
		//married to laurelin
		familyTree.Add("Jordan");
		//son of laurelin and jordan
		familyTree.Add("Benjamin");

		print(emailList[3]);
		print(emailList[5]);
		print(emailList[6]);

		print(catNamesList[1]);
		print(catNamesList[2]);
		print(catNamesList[3]);
		print(catNamesList[5]);

		print(familyTree[8]);

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
