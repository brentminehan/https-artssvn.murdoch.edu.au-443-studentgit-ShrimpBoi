using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoffeeGrinder : MonoBehaviour {

	public Transform spawnPoint; // give a spawn point 
	public GameObject coinPrefab; // hold prefab gameObject to instantiate

	void OnTriggerEnter (Collider co) {
		
		if (co.gameObject.tag == "battery") {
			Instantiate (coinPrefab, spawnPoint.position, spawnPoint.rotation);

		}
	}
	
}
