using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ambientClouds : MonoBehaviour {

	public Transform[] path;
	public float speed = 5.0f;
	public float reachDist = .1f;
	public int currentPoint = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float dist = Vector3.Distance(path[currentPoint].position, transform.position);

		transform.position = Vector3.MoveTowards(transform.position, path[currentPoint].position, Time.deltaTime*speed);

		if (dist <= reachDist) {
			currentPoint++;
		}

		if (currentPoint >= path.Length) {
			currentPoint = 0;
		}
	}

	void OnDrawGizmos () {
		if (path.Length > 0) {
			for (int i = 0; i < path.Length; i++) {
				Gizmos.DrawSphere(path[i].position, reachDist);
			}
		}

	}
}
