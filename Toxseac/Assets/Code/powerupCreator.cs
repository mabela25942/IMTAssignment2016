using UnityEngine;
using System.Collections;

public class powerupCreator : MonoBehaviour
{


	public GameObject gcoin;
	public GameObject heart;
	public GameObject ammo;


	float gcoinPosition;
	float heartPosition;
	float ammoPosition;



	IEnumerator creategcoin ()
	{
		while (true) {

			gcoinPosition = Random.Range (-6f, 6f);
			

			Instantiate (gcoin, new Vector3 (gcoinPosition, 5, 4), Quaternion.identity);
			

			yield return new WaitForSeconds (7f);
		}
	}
	
	IEnumerator createheart ()
	{
		while (true) {

			heartPosition = Random.Range (-6f, 6f);
			

			Instantiate (heart, new Vector3 (heartPosition, 5, 4), Quaternion.identity);
			

			yield return new WaitForSeconds (9f);
		}
		
	}

	IEnumerator createammo ()
	{
		while (true) {

			ammoPosition = Random.Range (-6f, 6f);


			Instantiate (ammo, new Vector3 (ammoPosition, 5, 4), Quaternion.identity);


			yield return new WaitForSeconds (9f);
		}

	}
		

	void Start ()
	{

		StartCoroutine ("createheart");
		StartCoroutine ("creategcoin");
		StartCoroutine ("createammo");


	}

	void Update ()
	{
		if (transform.position.y < -6) {
			Destroy (this.gameObject);
		}
	}
}
