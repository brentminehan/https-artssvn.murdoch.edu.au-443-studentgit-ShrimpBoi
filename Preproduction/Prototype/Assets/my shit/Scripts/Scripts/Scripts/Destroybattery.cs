using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroybattery : MonoBehaviour {

	public void OnTriggerEnter(Collider other) 
	{
		if(other.tag == "battery")
		{
			Destroy(other.gameObject);
		}
	}
}