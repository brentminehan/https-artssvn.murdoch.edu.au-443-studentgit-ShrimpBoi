using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager> {

	public int _numCoins;

	public int NumCoins
	{
		get {
			return _numCoins;
		
		}
		set {

			_numCoins = value;
		}
	
	}
}
