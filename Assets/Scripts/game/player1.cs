using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class player1 : MonoBehaviour {

	public Rigidbody Bullet;
	public Transform Fpoint;
	private Rigidbody m_Rigidbody;
	private Transform m_transform;
	private int Speed = 20;
	private int Speed_move = 2;
	private int Speed_rotate = 90;

	// Use this for initialization
	void Start () {
		m_Rigidbody = gameObject.GetComponent<Rigidbody> ();
		m_transform = gameObject.GetComponent<Transform> ();
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.UpArrow)){
			m_Rigidbody.MovePosition (m_transform.position + m_transform.forward * 0.2f);
		}

		if (Input.GetKey (KeyCode.LeftArrow)){
			m_transform.Rotate (Vector3.up * Time.deltaTime * -Speed_rotate);
		}

		if (Input.GetKey (KeyCode.RightArrow)){
			m_transform.Rotate (Vector3.up * Time.deltaTime * Speed_rotate);
		}

		if (Input.GetKey (KeyCode.DownArrow)){
			m_Rigidbody.MovePosition (m_transform.position - m_transform.forward * 0.2f);
		}

		if (Input.GetKeyDown (KeyCode.KeypadPeriod)) {
			Rigidbody clone;
			clone = (Rigidbody)Instantiate (Bullet, Fpoint.position, Fpoint.rotation);
			clone.velocity = transform.TransformDirection (Vector3.forward * 50);
			Destroy (clone.gameObject, 3.0f);
		}
	}

	void OnCollisionEnter(Collision coll) {
		if (coll.gameObject.tag == "bullet") {
			Destroy (coll.gameObject);
			Destroy (m_Rigidbody.gameObject);
			SceneManager.LoadScene ("front_page");
		}
	}
}
