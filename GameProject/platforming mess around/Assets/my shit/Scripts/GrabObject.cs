using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabObject : MonoBehaviour 
{
	public GameObject box; 
	public GameObject Replacer;

	public bool CanGrab; 
	
	// Use this for initialization
	void Start () 
	{
		CanGrab = false; 
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (CanGrab && Input.GetKey(KeyCode.E))
		{
			box.GetComponent<FixedJoint> ().connectedBody = this.GetComponent<Rigidbody> (); 
		}
		else if (Input.GetKeyUp (KeyCode.E)) 
		{
			box.GetComponent<FixedJoint> ().connectedBody = Replacer.GetComponent<Rigidbody> ();
		}
	}

	void OnTriggerEnter (Collider col)
	{
		if (col.gameObject.tag == "PuzzlePiece")
		{
			print ("yeet");
			CanGrab = true; 
		}
	}
	}
