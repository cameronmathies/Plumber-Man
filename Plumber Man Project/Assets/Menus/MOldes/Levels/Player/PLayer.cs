using UnityEngine;
using System.Collections;

public class PLayer : MonoBehaviour {

	void Move(){
		if (Input.GetKey(KeyCode.UpArrow)) {
			transform.Translate (Vector3.up);
			Debug.Log ("UpArrow makes me go up");
			}
			if (Input.GetKey(KeyCode.W)) {
			transform.Translate (Vector3.up);		
			Debug.Log ("W makes me go up");
		}
			}

}

