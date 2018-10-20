using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Caching : MonoBehaviour 
{
	public AudioClip MyClip;
	AudioSource audioSource;

	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "player") 
		
		{

			this.GetComponent<AudioSource> ().clip = MyClip;

			this.GetComponent<AudioSource> ().Play ();

		}
	}
}