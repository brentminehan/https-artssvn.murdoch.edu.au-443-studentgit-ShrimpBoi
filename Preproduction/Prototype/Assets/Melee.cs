using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Melee : MonoBehaviour {

	public Animator anim;
	public float speed;
	
	void Start () {
		
	}
	
	
	void Update () {


		speed = anim.GetFloat("Forward");
		
		if(speed >= 0.8 && Input.GetButtonDown("Fire1"))
		
		{
			Punch();
		}
	}

	private void Punch()
	{
		anim.SetTrigger("Punch");
		return;
	}


}
