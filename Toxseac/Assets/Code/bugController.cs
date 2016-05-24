using UnityEngine;
using System.Collections;

public class bugController : MonoBehaviour
{

	public int bugSpeed;

	void Start ()
	{
	
	}

	void Update ()
	{


	

		transform.Rotate (new Vector3 (0, 0, 1) * bugSpeed * Time.deltaTime);


		if (transform.position.y > -4) {

			transform.Translate (new Vector3 (0, -1, 0) * bugSpeed * Time.deltaTime, Space.World);
		} else {

			Destroy (this.gameObject);
			fishController.score--;

		}
				
			
	}
}
