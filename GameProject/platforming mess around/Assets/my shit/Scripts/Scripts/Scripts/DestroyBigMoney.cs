using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBigProp : MonoBehaviour {

	public void OnTriggerEnter(Collider other) 
	{
		if(other.tag == "BigProps")
		{
			Destroy(other.gameObject);
		}
	}
}