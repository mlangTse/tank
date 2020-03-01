using UnityEngine;
using System.Collections;

public class ball_move : MonoBehaviour {

	private Transform ball_transform;

	// get game object transform
	void Start () {
		ball_transform = gameObject.GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.UpArrow) || Input.GetKey (KeyCode.W)){
			ball_transform.Translate (Vector3.forward * 0.1f, Space.Self);
		}

		if (Input.GetKey (KeyCode.LeftArrow) || Input.GetKey (KeyCode.A)){
			ball_transform.Translate (Vector3.left * 0.1f, Space.Self);
		}

		if (Input.GetKey (KeyCode.RightArrow) || Input.GetKey (KeyCode.D)){
			ball_transform.Translate (Vector3.right * 0.1f, Space.Self);
		}

		if (Input.GetKey (KeyCode.DownArrow) || Input.GetKey (KeyCode.S)){
			ball_transform.Translate (Vector3.back * 0.1f, Space.Self);
		}

	}
}
