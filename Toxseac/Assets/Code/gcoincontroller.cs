using UnityEngine;
using System.Collections;

public class gcoincontroller : MonoBehaviour
{

	public int GCoinSpeed;

	void Start ()
	{
		
	}

	void Update ()
	{


		transform.Rotate (new Vector3 (0, 0, 1) * GCoinSpeed * Time.deltaTime);
		

		if (transform.position.y > -4) {

			transform.Translate (new Vector3 (0, -1, 0) * GCoinSpeed * Time.deltaTime, Space.World);
		} else {

			Destroy (this.gameObject);

		}
		
		
	}
}
