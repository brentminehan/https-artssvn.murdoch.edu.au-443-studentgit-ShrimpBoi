using UnityEngine;
using System.Collections;

public class openclose3: MonoBehaviour 
{
	public GameObject youranimatableObject;
	private Animator yourAnimator;

	void Start()
	{      
		yourAnimator = youranimatableObject.GetComponent<Animator>();
	}

	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "player")
		{
			yourAnimator.GetComponent<Animation> ().Play ("Take 001");
		} 
	}


}
