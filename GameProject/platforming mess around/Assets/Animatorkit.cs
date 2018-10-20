using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animatorkit : MonoBehaviour 
{

	public Animator anim;

	
	void Start () 
	{
		
	}
	
	
	void Update () 
	{


	
		
		if (Input.GetKey ("d"))
		{
			Punch ();
		}
			
		else 
		
		{
			Idle ();
		}

		if (Input.GetKey ("a"))
		{
			Punch2 ();
		}

		else 

		{
			IdleL ();
		}

		if (Input.GetButtonDown ("Jump"))
		{
			Jump ();
		}

		/*if (Input.GetButtonDown ("Sprint") && Input.GetKeyDown ("d"))
		{
			Sprint ();
		}
*/
	}
	void OnTriggerStay(Collider col)
	{
		if (col.gameObject.tag == "SkateSurface") 
		{
            Skateo ();
		} 
		
		else
		{
			Idle ();
		}

		if (col.gameObject.tag == "NonSkate") 
		{
            SkateoEnd ();
		} 

	}


	        private void Skateo()
	{
		anim.SetBool("IsSkating", true);
		return;
	}
	
		        private void SkateoEnd()
	{
		anim.SetBool("IsSkating", false);
		return;
	}
	private void Punch()
	{
		anim.SetTrigger("Is running");
		return;
	}

	private void Punch2()
	{
		anim.SetTrigger("Is runningL");
		return;
	}


	private void Idle()
	{
		anim.SetTrigger ("idle");
		
		return;
	}

	private void IdleL()
	{
		anim.SetTrigger ("idleL");
		return;
	}

	private void Jump()
	{
		anim.SetTrigger ("jump");

		return;
	}

	/*private void Sprint()
	{
		anim.SetTrigger ("Sprinting");

		return;
	}
*/

}
