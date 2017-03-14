using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KukeController : MonoBehaviour {

	public Text fishNumber;
	public Text rawKaloNumber;
	public Text meatNumber;
	public Text lauNumber;

	void Start() {
		fishNumber.text = GameControl.control.fish.ToString();
		rawKaloNumber.text = GameControl.control.kaloRaw.ToString();
		meatNumber.text = GameControl.control.meat.ToString();
		lauNumber.text = GameControl.control.lauLeaves.ToString();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
