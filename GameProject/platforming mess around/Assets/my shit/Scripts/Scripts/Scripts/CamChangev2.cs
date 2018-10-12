using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamChangev2 : MonoBehaviour
{
	
	public GameObject beacon;

	void Update ()
	{
		if (Input.GetButtonDown ("space")) {
			beacon.SetActive (false);


		}

		if (Input.GetButtonUp ("space")) 
		{
			beacon.SetActive (true);
		}
}
}
	






				