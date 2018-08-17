using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMover : MonoBehaviour {
	public float moveSpeed = 4f; 
	public GameObject carrotBoi; 
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.localPosition = Vector3.MoveTowards (transform.localPosition, new Vector3 (carrotBoi.transform.position.x, this.transform.position.y, this.transform.position.z), moveSpeed * Time.deltaTime);
	}
}
