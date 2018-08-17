using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deathcamera : MonoBehaviour {

	public GameObject Cam1;
	public GameObject Cam2;
	public GameObject Cam3;
	public GameObject Cam4;

		
	public void OnTriggerEnter(Collider other) 
	{
		if(other.tag == "Swap" && Input.GetMouseButtonDown(0))
		{
			Debug.Log ("Swamp");
			Cam1.SetActive (true);
			Cam2.SetActive (false);
			Cam3.SetActive (false);
			Cam4.SetActive (false);
		}
		if(other.tag == "Swap2" && Input.GetMouseButtonDown(0))
		{
			Debug.Log ("Swamp2");
			Cam1.SetActive (false);
			Cam2.SetActive (true);
			Cam3.SetActive (false);
			Cam4.SetActive (false);
		}
		if(other.tag == "Swap3" && Input.GetMouseButtonDown(0))
		{
			Debug.Log ("Swamp3");
			Cam1.SetActive (false);
			Cam2.SetActive (false);
			Cam3.SetActive (true);
			Cam4.SetActive (false);
		}
		if(other.tag == "Swap4" && Input.GetMouseButtonDown(0))
		{
			Debug.Log ("Swamp4");
			Cam1.SetActive (false);
			Cam2.SetActive (false);
			Cam3.SetActive (false);
			Cam4.SetActive (true);
		}
	}
}