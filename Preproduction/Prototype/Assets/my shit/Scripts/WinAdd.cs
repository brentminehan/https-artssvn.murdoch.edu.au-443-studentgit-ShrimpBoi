using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinAdd : MonoBehaviour 
{
	void OnTriggerEnter (Collider col)
	{
		PlayerHealth.WinState += 1;
		
	}
}
