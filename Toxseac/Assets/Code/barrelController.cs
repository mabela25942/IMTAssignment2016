using UnityEngine;
using System.Collections;

public class barrelController : MonoBehaviour
{

	public int barrelSpeed;

	void Start ()
	{
		
	}

	void Update ()
	{


		transform.Rotate (new Vector3 (0, 0, 1) * barrelSpeed * Time.deltaTime);
		

		if (transform.position.y > -4) {

			transform.Translate (new Vector3 (0, -1, 0) * barrelSpeed * Time.deltaTime, Space.World);
		} else {

			Destroy (this.gameObject);
			fishController.score--;
			fishController.lives--;

		}
		
		
	}
}
