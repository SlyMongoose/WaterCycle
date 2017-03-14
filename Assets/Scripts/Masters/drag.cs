using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class drag : MonoBehaviour {

	public Text kaloCounter;
	public float distance = 10f;
	private Vector3 startPos;

	void Start() {
		startPos = gameObject.GetComponent<Transform>().position;
	}

	void OnMouseDrag () {
		Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance);
		Vector3 objPosition = Camera.main.ScreenToWorldPoint (mousePosition);
		transform.position = objPosition;
	}

	void OnMouseUp () {
		transform.position = startPos;
	}
}
