using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitBoxManager : MonoBehaviour {

	public float startValue;
	public float fillRate;
	private bool inHitbox;

	void Awake () {
		inHitbox = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (inHitbox == true) {
			Debug.Log("enter");
			startValue = startValue + fillRate;
		}
	}

	void OnTriggerEnter2D (Collider2D other) {
		if (other.gameObject.CompareTag("cloud")){
			inHitbox = true;
		}
	}

	void OnTriggerExit2D (Collider2D other) {
		if (other.gameObject.CompareTag("cloud")){
			inHitbox = false;
		}
	}
}
