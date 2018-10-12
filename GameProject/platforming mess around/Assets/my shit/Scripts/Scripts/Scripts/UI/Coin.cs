using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour 
{

	public AudioClip MyClip;
	AudioSource audioSource;

	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "player") {
		
		this.GetComponent<AudioSource> ().clip = MyClip;

			this.GetComponent<AudioSource> ().Play ();
			
			pickUp ();

			
		}
	}

	private void pickUp ()
	{
		GameManager.Instance.NumCoins++;
		Destroy (gameObject);


	}
	
	// instead of Update per scene We need Coroutines(or you can do with update) for spinning and rotating coin
	
}
