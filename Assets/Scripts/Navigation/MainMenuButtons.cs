using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuButtons : MonoBehaviour {

	public Image gs;
	public Sprite alternate;
	public Sprite original;

	void OnMouseEnter () {
		gs.sprite = alternate;
	}

	void OnMouseExit () {
		gs.sprite = original;
	}
}
