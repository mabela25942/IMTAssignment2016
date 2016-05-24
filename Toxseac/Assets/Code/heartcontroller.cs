using UnityEngine;
using System.Collections;

public class heartcontroller : MonoBehaviour
{

	public int heartSpeed;

	void Start ()
	{
		
	}

	void Update ()
	{

		transform.Rotate (new Vector3 (0, 0, 1) * heartSpeed * Time.deltaTime);
		

		if (transform.position.y > -4) {

			transform.Translate (new Vector3 (0, -1, 0) * heartSpeed * Time.deltaTime, Space.World);
		} else {

			Destroy (this.gameObject);

		}
		
		
	}
}
