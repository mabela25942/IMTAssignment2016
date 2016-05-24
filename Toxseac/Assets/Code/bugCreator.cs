using UnityEngine;
using System.Collections;

public class bugCreator : MonoBehaviour
{


	public GameObject bug;
	public GameObject barrel;
	float bugPosition;
	float barrelPosition;

	IEnumerator createbug ()
	{
		while (true) {

			bugPosition = Random.Range (-6f, 6f);


			Instantiate (bug, new Vector3 (bugPosition, 5, 4), Quaternion.identity);


			yield return new WaitForSeconds (3f);
		}
	}

	IEnumerator createbarrel ()
	{
		while (true) {

			barrelPosition = Random.Range (-6f, 6f);
			

			Instantiate (barrel, new Vector3 (barrelPosition, 5, 4), Quaternion.identity);
			

			yield return new WaitForSeconds (3f);
		}
	}
		

	void Start ()
	{

		StartCoroutine ("createbug");
		StartCoroutine ("createbarrel");

	}

	void Update ()
	{

	}
}
