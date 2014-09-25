using UnityEngine;
using System.Collections;

public class Player_1_Tour : MonoBehaviour {

	public bool P2_Turn;
	public bool P1_Turn = true;
	public GameObject Boutton_Bleu;
	public Camera OpponentCam;

	// Le joueur 1 commence la partie, donc P1_Turn est Vraie, et P2_Turn est Fausse
	// Le joueur 1 peut appuyer sur son boutton seulement si P1_Turn est Vraie, meme chose pour le 2eme joueur avec P2_Turn
	// Lorsque le joueur a appuyer sur son Boutton, ici le "Bleu", P1_Turn deviens Fausse et P2_Turn devien Vraie.
	// 
	
	void Start ()
	{
		// P2_Turn = P2Cam.GetComponent<Player_2_Tour>().P2_Turn;
	}

	void Update ()
	{
		P2_Turn = OpponentCam.GetComponent<Player_2_Tour>().P2_Turn;
		if (P2_Turn == false) 
		{
			P1_Turn = true;
			// Debug.Log("Bool Works");
		}

		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;
		
		if(Input.GetMouseButtonDown(0) && P1_Turn) 
		{
			if(Physics.Raycast(ray,out hit,100) && hit.collider.gameObject.name == "Blue_Button")
		    {
				Debug.Log("Hit");
		 	    Boutton_Bleu.animation.Play("Blue");
				P1_Turn = false;
		    }
	    }

    }
}