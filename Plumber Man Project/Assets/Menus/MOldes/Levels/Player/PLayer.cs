using UnityEngine;
using System.Collections;

public class PLayer : MonoBehaviour {
	public float moveSpeed;
	public GameObject deathParticles;
	public float Speed = 1f;
	public float Force = 1f;
	public float hitForce;
	
	private Vector3 input;
	private Vector3 spawn;
		FixedUpdate(){

		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.Translate (Vector3.left * Time.deltaTime * moveSpeed, Camera.main.transform);
		}

		if (Input.GetKey (KeyCode.DownArrow)) {
			transform.Translate (Vector3.down * Time.deltaTime * 7, Camera.main.transform);
		}

			if (Input.GetKey (KeyCode.DownArrow)) {
				transform.Translate (Vector3.down * Time.deltaTime * 7, Camera.main.transform);
		}

		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.Translate (Vector3.left * Time.deltaTime * moveSpeed, Camera.main.transform);
			}






	}
}

