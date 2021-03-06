using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastHold2 : MonoBehaviour {
	
	GameObject fpsCam;
	GameObject deadCam;
	GameObject holdingObj;
	bool isHolding = false;
	public float distance;
	public float smooth;
	
	// Use this for initialization
	void Start () {
		fpsCam = GameObject.FindWithTag("MainCamera");
		deadCam = GameObject.FindWithTag ("DeadCam");
	}
	
	// Update is called once per frame
	void Update () {
		
		
		if(isHolding){
			Hold(holdingObj);
		}
		else
			Pickup();
	}//end Update()
	
	
	
	void Hold(GameObject obj){
		
		obj.GetComponent<Rigidbody>().isKinematic = true;
		
		obj.transform.position = Vector3.Lerp(obj.transform.position, fpsCam.transform.position + fpsCam.transform.forward * distance, Time.deltaTime * smooth);
		
		
		if(Input.GetButtonDown("Fire1")){
			
			obj.GetComponent<Rigidbody>().isKinematic = false;
			obj.transform.position = obj.transform.position;
			isHolding = false;
			
		}
		
	}//end hold()
	
	
	
	void Pickup(){
		
		
		
		if(Input.GetButtonDown("Fire1")){//1
			
						
			Ray ray = fpsCam.GetComponent<Camera>().ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2));
			RaycastHit hit;
			
			if(Physics.Raycast(ray, out hit)){//2
				
				CanHold i = hit.collider.GetComponent<CanHold>();
				
				if(i != null){//3
					
					isHolding = true;
					holdingObj = i.gameObject;

					Debug.Log ("Object picked up: " + holdingObj.name);

					holdingObj.transform.SetParent (deadCam.transform);

					var offset = holdingObj.GetComponent<handoffset> ();

					//holdingObj.transform.rotation = deadCam.transform.rotation;


					holdingObj.transform.position = deadCam.transform.position;
					holdingObj.transform.position += new Vector3 (offset.grabOffsetX, offset.grabOffsetY, offset.grabOffsetZ);
				}//3
			}//2	
		}//1
	}//End pickup()
}
