using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour {

	public int playerHealth=20;
	int damage=10;
	int Heal=10;

	public AudioClip MyClip;
	public AudioClip Death;

	public Transform spawnPoint; // give a spawn point 
	public GameObject coinPrefab; // hold prefab gameObject to instantiate


	AudioSource audioSource;




	void Start () 
	{
		print (playerHealth);
	}

	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "Weapon")
		{
			playerHealth -= damage;
			print ("ouchEnemy" + playerHealth);
			this.GetComponent<AudioSource> ().clip = MyClip;

			this.GetComponent<AudioSource> ().Play ();
		}
			

		if (playerHealth == 0) {
			print ("DEADEnemy");

			Instantiate (coinPrefab, spawnPoint.position, spawnPoint.rotation);

			this.GetComponent<AudioSource> ().clip = Death;

			this.GetComponent<AudioSource> ().Play ();

			Destroy (gameObject);


		}
	}
	

}
