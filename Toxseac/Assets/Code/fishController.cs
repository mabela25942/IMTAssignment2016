﻿using UnityEngine;
using System.Collections;

public class fishController : MonoBehaviour
{


	Vector3 mousePos;
	Vector3 mPos;
	public GameObject laser;
	public GUISkin stylesheet;
	public AudioClip laserSound;
	public static int score;
	public static int lives;
	public static int ammo;
	
	void Start ()
	{
		lives = 6;
		score = 0;
		ammo = 20;
	}

	void OnGUI ()
	{

		GUI.skin = stylesheet;

		string ScoreLabel = "Score: ";
		string LivesLabel = "Lives: ";
		string AmmoLabel = "Ammo: ";
			
		GUI.Label (new Rect (10f, 10f, 80, 20), ScoreLabel + score);

		GUI.Label (new Rect (Screen.width - 80f, 10f, 80, 20), LivesLabel + lives);

		GUI.Label (new Rect (10f, 880f, 80, 20), AmmoLabel + ammo);


		if (GUI.Button (new Rect (Screen.width / 2 - 300f, 25f, 700f, 25f), "QUIT")) {

			if (PlayerPrefs.GetInt ("score") < score) {
				PlayerPrefs.SetInt ("score", score);
			}
			//Application.LoadLevel (0);
		}
	}
	
	void Update ()
	{

		mousePos = Input.mousePosition;
		mPos = Camera.main.ScreenToWorldPoint (mousePos);
		transform.position = new Vector3 (mPos.x, -3.7f, 4f);
				
			
		if (Input.GetMouseButtonDown (0)) {
			GetComponent<AudioSource> ().PlayOneShot (laserSound);
			Instantiate (laser, new Vector3 (transform.position.x, transform.position.y, 4.1f), Quaternion.Euler (new Vector3 (0, 0, 90))); 
			ammo--;
		}	
			
		if (lives == 0) {
			if (PlayerPrefs.GetInt ("score") < score) {
				PlayerPrefs.SetInt ("score", score);
			}
			Application.LoadLevel ("lose");
			score = 0;
			lives = 6;
			ammo = 20;
		}

		if (Input.GetKeyDown (KeyCode.Escape)) {
						
			if (PlayerPrefs.GetInt ("score") < score) {
				PlayerPrefs.SetInt ("score", score);
			}


			Application.LoadLevel ("menu");
		}

		if (score == 10) {
			Application.LoadLevel ("mainlv2");
		}

		if (lives <= 0) {
			Application.LoadLevel ("lose");
		}
		if (ammo <= 0) {
			Application.LoadLevel ("lose");
		}

	}
	
	void OnTriggerEnter2D (Collider2D otherObject)
	{
		if (otherObject.tag == "bug") {
			score++;
			Destroy (otherObject.gameObject);
		}
	
		if (otherObject.tag == "barrel") {
			lives--;
			Destroy (otherObject.gameObject);
		}
	
		if (otherObject.tag == "heart") {
			lives++;
			Destroy (otherObject.gameObject);
		}
	
		if (otherObject.tag == "gcoin") {
			score++;
			Destroy (otherObject.gameObject);
		}
		if (otherObject.tag == "ammo") {
			ammo++;
			Destroy (otherObject.gameObject);
		}
	
	}
}
