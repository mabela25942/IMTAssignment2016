using UnityEngine;
using System.Collections;

public class ammoController : MonoBehaviour
{

	public int ammoSpeed;

	void Start ()
	{

	}

	void Update ()
	{


		transform.Rotate (new Vector3 (0, 0, 1) * ammoSpeed * Time.deltaTime);


		if (transform.position.y > -4) {

			transform.Translate (new Vector3 (0, -1, 0) * ammoSpeed * Time.deltaTime, Space.World);
		} else {

			Destroy (this.gameObject);

		}


	}
}