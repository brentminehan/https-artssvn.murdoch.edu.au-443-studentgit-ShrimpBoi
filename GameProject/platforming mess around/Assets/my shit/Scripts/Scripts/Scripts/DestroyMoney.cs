using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyMoney : MonoBehaviour {

	public void OnTriggerEnter(Collider other) 
	{
		if(other.tag == "Props")
		{
			Destroy(other.gameObject);
		}
	}
}