using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageScript : MonoBehaviour
{
	public int Damage;
	void OnTriggerEnter (Collider col)
	{
		PlayerHealth.health -= Damage;
	}

}
