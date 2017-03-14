using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class animalController : MonoBehaviour {

	public float moveSpeed;
	public float aliveTime;
	private float aliveTimeCounter;
	private Rigidbody2D myRigidBody;

	public Text polokaNumber;

	private bool moving;

	public float timeBetweenMove;
	private float timeBetweenMoveCounter;
	public float timeToMove;
	private float timeToMoveCounter;

	private Vector3 moveDirection;


	// Use this for initialization
	void Start () {
		myRigidBody = GetComponent<Rigidbody2D>();

		timeBetweenMoveCounter = timeToMove;
		timeToMoveCounter = timeToMove;
		aliveTimeCounter = aliveTime;
	}

	void Awake() {
		polokaNumber.text = GameControl.control.polokaCaught.ToString();
	}
	
	// Update is called once per frame
	void Update () {
		aliveTime -= Time.deltaTime;

		if(aliveTime < 0) {
			gameObject.SetActive(false);
			aliveTime = aliveTimeCounter;
		}

		if (moving) {
			timeToMoveCounter -= Time.deltaTime;
			myRigidBody.velocity = moveDirection;

			if (timeToMoveCounter < 0) {
				moving = false;
				timeBetweenMoveCounter = timeBetweenMove;
			}
		}
		else {
			timeBetweenMoveCounter -= Time.deltaTime;
			myRigidBody.velocity = Vector2.zero;

			if(timeBetweenMoveCounter < 0) {
				moving = true;
				timeToMoveCounter = timeToMove;

				moveDirection = new Vector3(Random.Range(-1f, 1f) * moveSpeed, Random.Range(-1f, 1f) * moveSpeed, 0f);
			}
		}
	}

	void OnMouseDown () {
		aliveTime = -1;
		GameControl.control.polokaCaught++;
		polokaNumber.text = GameControl.control.polokaCaught.ToString();
	}
}
