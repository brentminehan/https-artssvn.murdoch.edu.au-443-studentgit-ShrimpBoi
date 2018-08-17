using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthAdd : MonoBehaviour 
{
	void OnTriggerEnter (Collider col)
	{
		PlayerHealth.health += 1;
	}
}
