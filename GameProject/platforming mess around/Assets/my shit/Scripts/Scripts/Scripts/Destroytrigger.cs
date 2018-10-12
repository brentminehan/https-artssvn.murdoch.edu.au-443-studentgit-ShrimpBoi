using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroytrigger : MonoBehaviour {

	public void OnTriggerEnter(Collider other) 
	{
		if(other.tag == "panel")
		{
			Destroy(other.gameObject);
		}
	}
}