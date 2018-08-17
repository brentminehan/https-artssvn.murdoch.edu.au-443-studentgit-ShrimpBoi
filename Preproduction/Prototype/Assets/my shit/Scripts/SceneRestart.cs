using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneRestart : MonoBehaviour {

	
	void Update ()
	{
		if(Input.GetKeyDown(KeyCode.P))
		Application.LoadLevel(0);
	}
}
