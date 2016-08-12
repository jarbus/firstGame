using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public GameObject Player;

	// Use this for initialization
	void Start () {
	


	}
	
	// Update is called once per frame
	void Update () {
	
		float mouseX = Input.GetAxis ("Mouse X");
		float mouseY = Input.GetAxis ("Mouse Y");

		float z = transform.eulerAngles.z;
		transform.Rotate (0, 0, -z);

		if (mouseX < 0) {
			Player.transform.Rotate (0, mouseX, 0);
		}
		else if (mouseX > 0) {
			Player.transform.Rotate (0, mouseX, 0);
		}
		if (mouseY < 0) {
			gameObject.transform.RotateAround (Player.transform.position, new Vector3 ( -mouseY, 0, 0), 1);
		}
		else if (mouseY > 0) {
			gameObject.transform.RotateAround (Player.transform.position, new Vector3 ( -mouseY, 0, 0), 1);
		}
		//gameObject.transform.rotation = Quaternion.Euler (transform.rotation.x, transform.position.y, 0);
	}
}
