using UnityEngine;
using System.Collections;

public class laserController : MonoBehaviour
{

	public int laserSpeed;

	void Start ()
	{
	
	}

	void Update ()
	{

		transform.Translate (new Vector3 (1, 0, 0) * laserSpeed * Time.deltaTime); 


		if (transform.position.y > 5) {

			Destroy (this.gameObject);




		}
	}

	void OnTriggerEnter2D (Collider2D otherObject)
	{
		if (otherObject.tag == "barrel") {

			fishController.score++;

			Destroy (otherObject.gameObject);

			Destroy (this.gameObject);
		}
	
		if (otherObject.tag == "heart") {

			fishController.lives++;

			Destroy (otherObject.gameObject);

			Destroy (this.gameObject);
		}
	
		if (otherObject.tag == "gcoin") {

			fishController.score++;

			Destroy (otherObject.gameObject);

			Destroy (this.gameObject);
		}

		if (otherObject.tag == "ammo") {

			fishController.ammo++;

			Destroy (otherObject.gameObject);

			Destroy (this.gameObject);
		}
	}

}
