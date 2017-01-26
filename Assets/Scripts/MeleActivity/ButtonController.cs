using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour {

	private SpriteRenderer theSprite;
	public int thisButtonNumber;

	private MeleScript theGM;

	private AudioSource theSound;

	// Use this for initialization
	void Start () {
		theSprite = GetComponent<SpriteRenderer>();
		theGM = FindObjectOfType<MeleScript>();
		theSound = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown() {
		theSprite.color = new Color(theSprite.color.r + 125, theSprite.color.g + 125, theSprite.color.b + 125);
		theSound.Play();
	}

	void OnMouseUp() {
		theSprite.color = new Color(theSprite.color.r - 125, theSprite.color.g - 125, theSprite.color.b - 125);
		theGM.ColourPressed(thisButtonNumber);
		theSound.Stop();
	}
}
