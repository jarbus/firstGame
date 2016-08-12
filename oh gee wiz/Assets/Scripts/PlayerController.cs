using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float Speed;

	private Rigidbody R;

	void Start () {
		
		R = gameObject.GetComponent<Rigidbody> ();
	
	}


	void Update () {



	}


	void FixedUpdate () {

		float MoveH = Input.GetAxis ("Horizontal");
		float MoveV = Input.GetAxis ("Vertical");

		//if (MoveH > 0) {
			//R.velocity = transform.right * Speed;
		//}
		//else if (MoveH < 0) {
			//R.velocity = -transform.right * Speed;
		//}
		//if (MoveV > 0) {
			//R.velocity = transform.forward * Speed;
		//}
		//else if (MoveV < 0) {
			//R.velocity = -transform.forward * Speed;
		//}
		transform.position += transform.TransformDirection(MoveH * Speed, 0f, MoveV * Speed);

	}
}
