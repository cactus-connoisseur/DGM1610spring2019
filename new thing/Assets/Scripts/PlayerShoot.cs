using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour {
	public Transform firePoint;
	public GameObject projectile;

	public int maxAmmo = 10;
	// public in currentAmmo;

	// Use this for initialization
	void Start () {
		//load projectile from resources/prefabs folder
		projectile = Resources.Load("Prefabs/SunflowerSeedProjectile") as GameObject;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.RightControl))
			Instantiate(projectile,firePoint.position, firePoint.rotation);

		//script saying that every time you hit the right control button then you lose one ammo

		//if statement saying "if there is no more ammo (= 0) then you cant fire anymore

	}

}
