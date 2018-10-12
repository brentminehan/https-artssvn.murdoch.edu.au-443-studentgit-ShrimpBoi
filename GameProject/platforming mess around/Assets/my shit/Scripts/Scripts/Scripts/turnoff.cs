using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turnoff : MonoBehaviour {

	public GameObject beacon;
	public float spawnTime = 3f;
	bool beaconislit;

	void start ()
	{
		beacon.SetActive (true);
		beaconislit = true;
	}

	void Update ()
	{
		if (Input.GetButton ("Fire2")) 
		{
			print ("space key was pressed");
			beacon.SetActive (false);
			beaconislit = false;
			StartCoroutine (LightTheBeam());
		}
			
	}

	IEnumerator LightTheBeam()
	{
		print (Time.time);
		yield return new WaitForSeconds (spawnTime); 
		print (Time.time);
		beacon.SetActive (true);
		beaconislit = true;

	}
}