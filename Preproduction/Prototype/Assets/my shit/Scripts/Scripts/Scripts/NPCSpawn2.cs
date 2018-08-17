using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCSpawn2 : MonoBehaviour {

	public Transform spawnPoint; // give a spawn point 
	public GameObject[] coinPrefab; // hold prefab gameObject to instantiate
	public float spawnTime = 3f;
	private float spawnTimeP; 
	bool canISpawn; 

	void Start ()
	{
		canISpawn = true; 
	}
	void Update ()
	{
		Bbqtimer ();
	}

	private void Bbqtimer ()
	{
		if (canISpawn)
		{
		StartCoroutine (BbqInterval()); 
		}
	}

	IEnumerator BbqInterval()
	{
		canISpawn = false;
		Spawn ();
		yield return new WaitForSeconds (spawnTime); 
		Debug.Log ("am i gettin here");
		canISpawn = true; 
	}


	private void Spawn ()
	{
		Debug.Log ("Noongar "+ canISpawn);

			Instantiate (coinPrefab[Random.Range(0, coinPrefab.Length)], spawnPoint.position, spawnPoint.rotation);
			Destroy (gameObject);
	}
	
}
