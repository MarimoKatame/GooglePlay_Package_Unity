using UnityEngine;
using System.Collections;
using GooglePlayGames;
using UnityEngine.SocialPlatforms;

public class Menu : MonoBehaviour
{

	public GUISkin skin;


	//Debut du jeu

	void Srart()
	{
		PlayGamesPlatform.Activate();
	}

	//Update

	public void OnGUI()
	{
		GUI.skin = skin;
		skin.textField.fixedWidth = Screen.width - 15;
		skin.button.fixedWidth = Screen.width - 15;
		GUILayout.BeginArea (new Rect (0, 0, Screen.width, Screen.height));

		GUILayout.BeginVertical ("box");

		GUILayout.Label ("Awesome Game about Buttons");

		GUILayout.Space (20);

		//Se Connecter

		if (GUILayout.Button ("Log In")) 
		{
			Social.localUser.Authenticate((bool succes) =>
			{
				if (succes)
				{
					Debug.Log("You've successfully logged in");
				}
				else
				{
					Debug.Log("Login failed for some reason");
				}
			});
		}

		GUILayout.Space (20);

		// Jouer

		if (GUILayout.Button ("Play")) 
		{
			Application.LoadLevel("Test");
		}

		GUILayout.Space (20);

		// Se déconnecter

		if (GUILayout.Button ("Sign Out")) 
		{
			((PlayGamesPlatform)Social.Active).SignOut();
		}

		GUILayout.EndVertical ();
		GUILayout.EndArea ();
	}
}