using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagaer : MonoBehaviour {

	public ScoreManager theScoreManager; 

	public DeathMenu thedeathscreen;


	public void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player") 
		{
			theScoreManager.scoreIncreasing = false;
			thedeathscreen.gameObject.SetActive (true); 
		}
	}
}