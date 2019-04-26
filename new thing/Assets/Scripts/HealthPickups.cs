using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickups : MonoBehaviour {

	public int healthValue;

	void Update (){
		// animator.SetBool("isSpinning",true);
		
		 Vector3 scale = transform.localScale;
 
         scale.Set(0.5f, 0.5f, 1f);
 
         transform.localScale = scale;
	}
	
	void OnTriggerEnter2D(Collider2D other){
		if(other.tag == "Player"){

			print("You've collected the health pickup!");

			HealthManager.AddHealth(healthValue);

			Destroy(gameObject);
		}
		
	}

}
	

