using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathFind : MonoBehaviour {

	void Start() 
	{ 
		InvokeRepeating("FindPlayer", 0, 0.1f);
		 
	}
	void FindPlayer()
	{
		// Navigate to Counter
		GameObject player = GameObject.Find ("player");
		if (player)
			GetComponent<UnityEngine.AI.NavMeshAgent> ().destination = player.transform.position; 
	}
}




