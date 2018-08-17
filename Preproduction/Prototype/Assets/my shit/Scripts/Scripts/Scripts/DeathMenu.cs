using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathMenu : MonoBehaviour 
{
	public string Shrimpboi;
	public string mainMenuLevel;
	
	public void RestartGame()
	{
		Application.LoadLevel(Shrimpboi);
	}

	public void QuitToMaun()
	{
		Application.LoadLevel (mainMenuLevel); 
	}
}

