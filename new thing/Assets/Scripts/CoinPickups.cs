using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickups : MonoBehaviour {

	public int coinValue;

	void Update (){
		 Vector3 scale = transform.localScale;
 
         scale.Set(0.1f, 0.1f, 1f);
 
         transform.localScale = scale;
	}

	void OnTriggerEnter2D (Collider2D other){
		if(other.tag == "Player"){

			print("You've collected the coin!");

			ScoreManager.AddPoints(coinValue);

			Destroy(gameObject);

		}

	}

}
