using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class kaloController : MonoBehaviour {

	public float growOnceTime;
	public float finishGrowingTime;
	public Text kaloNumber;

	private float totalGrowTime;
	private int count;
	private bool isKaloReady;
	private bool isHarvestable;
	private bool hasPlant;

	// Use this for initialization
	void Start () {
		count = 0;
		totalGrowTime = 0;
		kaloNumber.text = GameControl.control.pulledKalo.ToString();
	}
	
	// Update is called once per frame
	void Update () {

		kaloNumber.text = GameControl.control.pulledKalo.ToString();

		if (count < 16) {
			switch (count) {
			case 1:
				gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load("papa2", typeof(Sprite)) as Sprite;
				break;
			case 2:
				gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load("papa3", typeof(Sprite)) as Sprite;
				break;
			case 3:
				gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load("papa4", typeof(Sprite)) as Sprite;
				break;
			case 4:
				gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load("papa5", typeof(Sprite)) as Sprite;
				break;
			case 5:
				gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load("papa6", typeof(Sprite)) as Sprite;
				break;
			case 6:
				gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load("papa7", typeof(Sprite)) as Sprite;
				break;
			case 7:
				gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load("papa8", typeof(Sprite)) as Sprite;
				break;
			case 8:
				gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load("papa9", typeof(Sprite)) as Sprite;
				break;
			case 9:
				gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load("papa91", typeof(Sprite)) as Sprite;
				break;
			case 10:
				gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load("papa92", typeof(Sprite)) as Sprite;
				break;
			case 11:
				gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load("papa93", typeof(Sprite)) as Sprite;
				break;
			case 12:
				gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load("muddy2", typeof(Sprite)) as Sprite;
				break;
			case 13:
				gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load("muddy3", typeof(Sprite)) as Sprite;
				break;
			case 14:
				gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load("muddy5", typeof(Sprite)) as Sprite;
				break;
			case 15:
				gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load("puu1", typeof(Sprite)) as Sprite;
				isKaloReady = true;
				break;
			}
		}

		if (hasPlant == true) {
			if (totalGrowTime < finishGrowingTime) {
				Debug.Log("really");
				totalGrowTime += Time.deltaTime;
				if (totalGrowTime > growOnceTime) {
					//change sprite to second growth stage
				}
			}
			else {
				gameObject.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load("kalo", typeof(Sprite)) as Sprite;
				isHarvestable = true;
			}
		}
	}

	void OnTriggerEnter2D(Collider2D collider) {
		Debug.Log("hello");
		if (collider.gameObject.tag == "ooHolder") {
			count++;
		}

		if (collider.gameObject.tag == "huliHolder") {
			if (isKaloReady == true) {
				gameObject.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load("hulispawn", typeof(Sprite)) as Sprite;
				hasPlant = true;
			}
		}
	}

	void OnMouseUp () {
		if (isHarvestable == true) {
			gameObject.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load(null, typeof(Sprite)) as Sprite;
			GameControl.control.lauLeaves++;
			GameControl.control.kaloRaw++;
			GameControl.control.pulledKalo++;
			totalGrowTime = 0;
			hasPlant = false;
		}
	}

	/*void OnDisable () {
		GameControl.control.pulledKalo = 0;
	}*/
}
