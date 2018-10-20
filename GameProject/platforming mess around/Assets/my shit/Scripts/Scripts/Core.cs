using UnityEngine;
using System.Collections;

public class Core: MonoBehaviour 
{

	public GameObject FusionB;
	public GameObject FusionR;
	public GameObject FusionG;
	public GameObject FusionY;

	public GameObject RedB;
	public GameObject RedR;
	public GameObject RedG;
	public GameObject RedY;

	int myInt = 0; 

	public GameObject NoCom;
	public GameObject ActiveCom;
	public GameObject BigButton;

	void Start ()
	{
		
		FusionB.SetActive (false);
		FusionR.SetActive (false);
		FusionG.SetActive (false);
		FusionY.SetActive (false);

		NoCom.SetActive (true);
		ActiveCom.SetActive (false);
		BigButton.SetActive(false);

	}

	void update ()
	{
		Debug.Log (myInt);
	}
		

	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "BlueBat") 
		{
		;
			RedB.SetActive (false);
			FusionB.SetActive (true);
			myInt += 1;
		
	
		} 
		if (col.gameObject.tag == "RedBat") 
		{
			;
			RedR.SetActive (false);
			FusionR.SetActive (true);
			myInt += 1;

		} 
		if (col.gameObject.tag == "YellowBat") 
		{
			;
			RedY.SetActive (false);
			FusionY.SetActive (true);
			myInt += 1;
		

		} 
		if (col.gameObject.tag == "GreenBat") 
		{
			;
			RedG.SetActive (false);
			FusionG.SetActive (true);
			myInt += 1;
		} 
		if (myInt == 4)
		{
			Debug.Log ("The Beacons LIT");
			NoCom.SetActive (false);
			ActiveCom.SetActive (true);
			BigButton.SetActive(true);

		}
	}


}
