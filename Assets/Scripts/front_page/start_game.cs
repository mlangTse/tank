using UnityEngine;
using System.Collections;

public class start_game : MonoBehaviour {

	private GUIText m_GUIText;

	// Use this for initialization
	void Start () {
		m_GUIText = gameObject.GetComponent<GUIText> ();
	}

	void OnMouseEnter() {
		m_GUIText.color = Color.red;
	}

	void OnMouseExit() {
		m_GUIText.color = Color.black;
	}

}
