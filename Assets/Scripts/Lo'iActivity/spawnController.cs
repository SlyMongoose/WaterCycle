using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnController : MonoBehaviour {
	public float spawnRangeBottom;
	public float spawnRangeTop;
	public GameObject poloka;

	private float timeTillNextSpawn;

	// Use this for initialization
	void Start () {
		timeTillNextSpawn = Random.Range(spawnRangeBottom, spawnRangeTop);
	}

	void Awake () {
		poloka.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		timeTillNextSpawn -= Time.deltaTime;

		if (timeTillNextSpawn < 0) {
			poloka.SetActive(true);

			timeTillNextSpawn = Random.Range(spawnRangeBottom, spawnRangeTop);
			//Instantiate(poloka, new Vector3(gameObject.GetComponent<Transform>().position.x, gameObject.GetComponent<Transform>().position.x, 0f), gameObject.GetComponent<Transform>().rotation);
		}
	}
}
