using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour {
	public Transform firePoint;
	public GameObject projectile;
	// float nextFire = 0.0f;
	public int ammo;

	
	// public in currentAmmo;

	// Use this for initialization
	void Start () {
		//load projectile from resources/prefabs folder
		projectile = Resources.Load("Prefabs/SunflowerSeedProjectile") as GameObject;

	}
	
	// Update is called once per frame
	void Update () {
		ammo = AmmoManager.ammo;

		if(Input.GetKeyDown(KeyCode.RightControl) && ammo > 0)
			Instantiate(projectile,firePoint.position, firePoint.rotation);

		//script saying that every time you hit the right control button then you lose one ammo

		//if statement saying "if there is no more ammo (= 0) then you cant fire anymore

	}

}
