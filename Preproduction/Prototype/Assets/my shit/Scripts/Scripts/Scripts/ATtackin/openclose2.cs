using UnityEngine;
using System.Collections;

public class openclose2: MonoBehaviour 
{
	public GameObject youranimatableObject;
	private Animator yourAnimator;

	void Start()
	{      
		yourAnimator = youranimatableObject.GetComponent<Animator>();
	}

	void Update()
	{
		if (Input.GetMouseButton (1)) 
		{
			yourAnimator.GetComponent<Animation> ().Play ("Turn off2");
		} 
		else if (Input.GetMouseButton (1)) 
		{
			yourAnimator.GetComponent<Animation> ().Stop ("Turn off2"); 
		}
	}


}
