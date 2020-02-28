using UnityEngine;
using System.Collections;

public class input_test : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// getkey
	void Update () {
		// get key input
		if (Input.GetKey (KeyCode.A)) {
			Debug.Log ("Got A..");
		}

		if (Input.GetKeyDown (KeyCode.A)) {
			Debug.Log ("press A");
		} else if (Input.GetKeyUp (KeyCode.A)) {
			Debug.Log ("relese A");
		}

		// get mouse input
		// 0 -> left, 1 -> middle 2 -> right
		if (Input.GetMouseButton (0)) {
			Debug.Log ("left click");
		}

		if (Input.GetMouseButtonDown (0)) {
			Debug.Log ("left button down");
		} else if (Input.GetMouseButtonUp (0)) {
			Debug.Log ("left button up");
		}
	}
}
