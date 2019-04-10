using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour {
	public Transform firePoint;
	public GameObject projectile;

	// Use this for initialization
	void Start () {
		//load projectile from resources/prefabs folder
		projectile = Resources.Load("Prefabs/SunflowerSeedProjectile") as GameObject;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.RightControl))
			Instantiate(projectile,firePoint.position, firePoint.rotation);

	}
}
