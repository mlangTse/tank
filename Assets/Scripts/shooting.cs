using UnityEngine;
using System.Collections;

public class shooting : MonoBehaviour {
	int Speed = 20;
	public Rigidbody Bullet;
	public Transform Fpoint;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.J)) {
			Rigidbody clone;
			clone = (Rigidbody)Instantiate (Bullet, Fpoint.position, Fpoint.rotation);
			clone.velocity = transform.TransformDirection (Vector3.forward * 50);
			Destroy (clone.gameObject, 2.0f);
		}
	}
}
