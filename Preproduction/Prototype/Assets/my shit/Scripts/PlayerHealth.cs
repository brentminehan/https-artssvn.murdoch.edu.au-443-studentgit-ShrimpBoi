using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {

    public GameObject Life1, Life2, Life3, GameOver;

    public GameObject Player;

    public GameObject WinGame;
    public static int health;

     public static int WinState;


  



	void Start ()
	{
	
        health = 3;
        WinState = 0;
        Life1.gameObject.SetActive (true);
        Life2.gameObject.SetActive (true);
        Life3.gameObject.SetActive (true);
        GameOver.gameObject.SetActive (false);
        
	}
	void Update ()
	{
        if (health > 3)
            health = 3;

        switch (health)   
        {
         case 3:
        Life1.gameObject.SetActive (true);
        Life2.gameObject.SetActive (true);
        Life3.gameObject.SetActive (true);
          GameOver.gameObject.SetActive (false);
        break;
          case 2:
        Life1.gameObject.SetActive (true);
        Life2.gameObject.SetActive (true);
        Life3.gameObject.SetActive (false);
          GameOver.gameObject.SetActive (false);
        break;
          case 1:
        Life1.gameObject.SetActive (true);
        Life2.gameObject.SetActive (false);
        Life3.gameObject.SetActive (false);
          GameOver.gameObject.SetActive (false);
        break;
           case 0:
        Life1.gameObject.SetActive (false);
        Life2.gameObject.SetActive (false);
        Life3.gameObject.SetActive (false);
          GameOver.gameObject.SetActive (true);
          Player.gameObject.SetActive (false);
         
         
        break;
            
        }      

       
	}

void FixedUpdate ()
{
  if (WinState > 1)
            WinState = 1;

            switch (WinState) 
            {
   
        case 1:

        WinGame.gameObject.SetActive (true);
        Player.gameObject.SetActive (false);
        
      
       
        break;
          case 0:
        WinGame.gameObject.SetActive (false);
          

        break;
        
            }
}
	
}
