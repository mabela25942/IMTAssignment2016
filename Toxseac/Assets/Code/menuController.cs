using UnityEngine;
using System.Collections;

public class menuController : MonoBehaviour
{


	public GUISkin style;
	public GUISkin style2;

	void OnGUI ()
	{

		GUI.skin = style;


		GUI.Label (new Rect (Screen.width / 2 - 100f, Screen.height / 2 - 50f, 200f, 100f), "Toxseac !!");

		if (GUI.Button (new Rect (Screen.width / 2 - 100f, Screen.height / 2 + 60f, 200f, 50f), "HELP")) {

			Application.LoadLevel (1);
		}
		

		if (GUI.Button (new Rect (Screen.width / 2 - 100f, Screen.height / 2 + 30f, 200f, 50f), "PLAY")) {

			Application.LoadLevel (2);
		}


		GUI.skin = style2;

		GUI.Label (new Rect (Screen.width / 2 - 100f, Screen.height / 2 + 80f, 200f, 100f), "High score: " + PlayerPrefs.GetInt ("score"));
	}

	void Start ()
	{
	
	}

	void Update ()
	{
	
	}
}
