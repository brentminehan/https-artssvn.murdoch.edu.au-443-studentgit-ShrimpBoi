using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatemoneyRiceMilk2 : MonoBehaviour {

	public Transform spawnPoint; // give a spawn point 
	public GameObject coinPrefab; // hold prefab gameObject to instantiate

	void OnTriggerEnter (Collider co) {
		
		if (co.gameObject.tag == "BeerBoi") {
			Instantiate (coinPrefab, spawnPoint.position, spawnPoint.rotation);
			Destroy (gameObject);
		}
	}
	
}
