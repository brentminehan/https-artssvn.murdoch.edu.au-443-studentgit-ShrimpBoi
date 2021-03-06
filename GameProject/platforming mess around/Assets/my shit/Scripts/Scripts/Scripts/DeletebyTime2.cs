using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeletebyTime2 : MonoBehaviour 
{

	public Transform spawnPoint; // give a spawn point 
	public GameObject coinPrefab; // hold prefab gameObject to instantiate
	public float lifetime = 3f;

	void Start ()
	{
		Instantiate (coinPrefab, spawnPoint.position, spawnPoint.rotation);
		Destroy (gameObject, lifetime);
	}
}