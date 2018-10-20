using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boyancy : MonoBehaviour {

	public float UpwardForce = 12.72f;
	private bool isInWater = false; 

	void OnTriggerEnter(Collider collider) 
	{
		isInWater = true;
		GetComponent<Rigidbody>().drag = 5f;
	}

	void OnTriggerExit(Collider collider)
	{
		isInWater = false;
		GetComponent<Rigidbody>().drag = 0.05f;
	}

	void FixedUpdate()
	{
		if(isInWater)
		{
			Vector3 force = transform.up * UpwardForce;
			this.GetComponent<Rigidbody>().AddRelativeForce(force, ForceMode.Acceleration);
			Debug.Log("Upward Force:" + force+ "@" + Time.time);
		}
	}
}
