using UnityEngine;
using System.Collections;

public class Player_2_Tour : MonoBehaviour {

	public bool P1_Turn;
	public bool P2_Turn = false;
	public GameObject Boutton_Rouge;
	public Camera OpponentCam;

	void Start ()
	{
		// P1_Turn = P2Cam.GetComponent<Player_1_Tour>().P1_Turn;
	}

	void Update ()
	{
		P1_Turn = OpponentCam.GetComponent<Player_1_Tour>().P1_Turn;
		if (P1_Turn == false)
		{
			P2_Turn = true;
			// Debug.Log("Bool Works");
		}

		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;
		
		if(Input.GetMouseButtonDown(0) && P2_Turn)
		{
			if(Physics.Raycast(ray,out hit,100) && hit.collider.gameObject.name == "Red_Button")
		    {
				Debug.Log("Hit2");
		 	    Boutton_Rouge.animation.Play("Red");
				P2_Turn = false;
		    }
	    }

    }
}