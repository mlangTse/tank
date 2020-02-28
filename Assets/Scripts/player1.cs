using UnityEngine;
using System.Collections;

public class player1 : MonoBehaviour {

	private Rigidbody m_Rigidbody;
	private Transform m_transform;

	// Use this for initialization
	void Start () {
		m_Rigidbody = gameObject.GetComponent<Rigidbody> ();
		m_transform = gameObject.GetComponent<Transform> ();
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.UpArrow)){
			m_Rigidbody.MovePosition (m_transform.position + Vector3.forward*0.1f);
		}

		if (Input.GetKey (KeyCode.LeftArrow)){
			m_Rigidbody.MovePosition (m_transform.position + Vector3.left*0.1f);
		}

		if (Input.GetKey (KeyCode.RightArrow)){
			m_Rigidbody.MovePosition (m_transform.position + Vector3.right*0.1f);
		}

		if (Input.GetKey (KeyCode.DownArrow)){
			m_Rigidbody.MovePosition (m_transform.position + Vector3.back*0.1f);
		}

		if (Input.GetKey (KeyCode.Space)){
			m_Rigidbody.MovePosition (m_transform.position + Vector3.up*0.1f);
		} 
	}
}
