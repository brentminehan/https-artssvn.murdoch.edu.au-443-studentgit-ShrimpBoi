using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {

	public int playerHealth=30;
	int damage=10;
	int Heal=10;
	public AudioClip MyClip;
	public AudioClip Death;
	public GameObject youranimatableObject;
	private Animator yourAnimator;


	AudioSource audioSource;






	void Start () 
	{
		print (playerHealth);
		yourAnimator = youranimatableObject.GetComponent<Animator>();
	}

	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "Enemy")
		{
			playerHealth -= damage;
			print ("ouch" + playerHealth);
			yourAnimator.GetComponent<Animation> ().Play ("Ouch");
			this.GetComponent<AudioSource> ().clip = MyClip;

			this.GetComponent<AudioSource> ().Play ();
		}
			
		if (playerHealth == 0) {
			print ("DEAD");

			Application.LoadLevel("Thrilla");

		}
	}
	

}
