using UnityEngine;
using System.Collections;

public class openclose: MonoBehaviour 
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
			yourAnimator.GetComponent<Animation> ().Play ("Swing");
		} 
		else if (Input.GetMouseButton (1)) 
		{
			yourAnimator.GetComponent<Animation> ().Stop ("Swing"); 
		}
	}


}
