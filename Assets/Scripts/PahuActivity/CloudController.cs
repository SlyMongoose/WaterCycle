using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudController : MonoBehaviour {

	public float moveSpeed;
	public Animator anim;
	public float pushTime;

	private bool beingPushed;
	private Rigidbody2D cloudRigidBody;
	private float pushTimeCounter;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
		pushTimeCounter = pushTime;
		cloudRigidBody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
			if(Input.GetAxisRaw("Horizontal") > 0.5f || Input.GetAxisRaw("Horizontal") < -0.5f) {
				//transform.Translate (new Vector3(Input.GetAxisRaw("Horizontal") * moveSpeed *Time.deltaTime, 0f, 0f));
				cloudRigidBody.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * moveSpeed, cloudRigidBody.velocity.y);

			}
				
			if(Input.GetAxisRaw("Vertical") > 0.5f || Input.GetAxisRaw("Vertical") < -0.5f) {
				cloudRigidBody.velocity = new Vector2(cloudRigidBody.velocity.x, Input.GetAxisRaw("Vertical") * moveSpeed);
			}
	}

	void OnTriggerEnter2D (Collider2D collider) {
		if (collider.tag == "kamakaniBlower") {
			cloudRigidBody.velocity = new Vector2(Random.Range(-1, 1), Random.Range(-1, 1));
		}

	}

	void OnTriggerStay2D (Collider2D collider) {
		if (collider.tag == "kamakaniBlower") {
			cloudRigidBody.velocity = new Vector2(Random.Range(-1, 1), Random.Range(-1, 1));
		}

	}
}
