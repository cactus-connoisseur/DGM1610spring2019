using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPC : MonoBehaviour {

	public MoveCharacter player;

	public bool isFollowing;
	

	//camera position offset
	public float xOffset;
	public float yOffset;

	// Use this for initialization
	void Start () {
		player = FindObjectOfType<MoveCharacter>();

		isFollowing = true;
	}
	
	// Update is called once per frame
	void Update () {
		//if(!isFollowing) this would make the code run of the camera isnt following
		//this code runs while camera follows 
		if(isFollowing){
			transform.position = new Vector3(player.transform.position.x + xOffset, player.transform.position.y + yOffset, transform.position.z);
		}
	}
}
