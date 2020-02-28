using UnityEngine;
using System.Collections;

public class rigidbodyMove : MonoBehaviour {

	private Rigidbody m_Rigidbody;
	private Transform m_transform;
	private int Speed_move = 2;
	private int Speed_rotate = 90;

	// Use this for initialization
	void Start () {
		m_Rigidbody = gameObject.GetComponent<Rigidbody> ();
		m_transform = gameObject.GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.UpArrow) || Input.GetKey (KeyCode.W)){
			m_Rigidbody.MovePosition (m_transform.position + m_transform.forward * 0.2f);
		}
		if (Input.GetKey (KeyCode.LeftArrow) || Input.GetKey (KeyCode.A)){
			m_transform.Rotate (Vector3.up * Time.deltaTime * -Speed_rotate);
		}

		if (Input.GetKey (KeyCode.RightArrow) || Input.GetKey (KeyCode.D)){
			m_transform.Rotate (Vector3.up * Time.deltaTime * Speed_rotate);
		}

		if (Input.GetKey (KeyCode.DownArrow) || Input.GetKey (KeyCode.S)){
			m_Rigidbody.MovePosition (m_transform.position - m_transform.forward * 0.2f);
		}

		if (Input.GetMouseButton (0)) {
			m_Rigidbody.AddForce (Vector3.forward, ForceMode.Impulse);
		}
	}
	/*
	// collision with other object
	void OnCollisionEnter(Collision coll){
		Debug.Log ("Enter " + coll.gameObject.name);
	}

	void OnCollisionExit(Collision coll){
		Debug.Log ("Exit " + coll.gameObject.name);
	}
	void OnCollisionStay(Collision coll){
		Debug.Log ("Stay " + coll.gameObject.name);
	}

	// into a trigger
	void OnTriggerEnter(Collider coll){
		Debug.Log ("ball enter " + coll.gameObject.name);
	}

	void OnTriggerExit(Collider coll){
		Debug.Log ("ball exit " + coll.gameObject.name);
	}

	void OnTriggerStay(Collider coll){
		Debug.Log ("ball stay " + coll.gameObject.name);
	}*/
}
