using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Changesceneonenter : MonoBehaviour {


	void OnTriggerEnter(Collider other)
	{
		if (other.transform.root.CompareTag("player"))
		{
			Application.LoadLevel("Menu");
		}
	}
}


