using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationPart2 : MonoBehaviour 
{

	public Animator anim; 

	private float inputH;
	private float inputV;



	// Use this for initialization
	void Start ()
	{
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () 
	{

		inputH = Input.GetAxis ("Horizontal");
		inputV = Input.GetAxis ("Vertical");

		anim.SetFloat("inputH", inputH);
		Debug.Log("yeet");
		anim.SetFloat("inputV", inputV); 
		
	}
}
