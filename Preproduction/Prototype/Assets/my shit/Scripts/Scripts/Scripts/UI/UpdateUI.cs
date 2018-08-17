using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateUI : MonoBehaviour {

	// Use this for initialization

	public Text CoinLabel;


	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		CoinLabel.text = GameManager.Instance.NumCoins.ToString ();
		
	}
}
