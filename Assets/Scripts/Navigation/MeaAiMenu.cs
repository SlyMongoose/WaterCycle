using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MeaAiMenu : MonoBehaviour {

	public GameObject MeaAiCanvas;
	public Text poi;
	public Text fish;
	public Text cookedKalo;
	public Text lau;
	public Text meat;

	void Awake() {
		MeaAiCanvas.SetActive(false);
	}

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		
	}

	public void displayMeaAi() {
		MeaAiCanvas.SetActive(true);
		poi.text = GameControl.control.poi.ToString();
		fish.text = GameControl.control.fish.ToString();
		cookedKalo.text = GameControl.control.kaloCooked.ToString();
		lau.text = GameControl.control.lauPrepped.ToString();
		meat.text = GameControl.control.meat.ToString();
	}

	public void closeMeaAi () {
		MeaAiCanvas.SetActive(false);
	}
}
