using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

	public GameObject prefabBolt;
	public AudioClip Myclip;

	void Start () {
		
	}
	

	void Update () {
		if (Input.GetMouseButtonDown (0)) 
		{
			Instantiate (prefabBolt);
			this.GetComponent<AudioSource> ().clip = Myclip;
			this.GetComponent<AudioSource> ().Play ();
			prefabBolt.transform.position = transform.position + Camera.main.transform.forward * 2;
			Rigidbody rb = prefabBolt.GetComponent<Rigidbody> ();
			rb.velocity = Camera.main.transform.forward * 40; 
		}
	}
}
