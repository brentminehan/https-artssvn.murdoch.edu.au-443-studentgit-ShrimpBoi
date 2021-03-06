using UnityEngine;
using System.Collections;

public class opendoor: MonoBehaviour 
{
	public GameObject youranimatableObject;
	private Animator yourAnimator;


	public GameObject batteryempty;
	public GameObject batteryfull;

	public float spawnTime = 3f;



	void Start()
	{      
		yourAnimator = youranimatableObject.GetComponent<Animator>();
		batteryempty.SetActive (true);
		batteryfull.SetActive (false);
	}

	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "battery") 
		{
			yourAnimator.GetComponent<Animation> ().Play ("Door close test");
			batteryempty.SetActive (false);
			batteryfull.SetActive (true);
			StartCoroutine (OpenDoor());
		} 
	}
	IEnumerator OpenDoor()
	{
		print (Time.time);
		yield return new WaitForSeconds (spawnTime); 
		print (Time.time);
		batteryempty.SetActive (true);
		batteryfull.SetActive (false);
		yourAnimator.GetComponent<Animation> ().Play ("Door open test");

	}

}
