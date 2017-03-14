using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour {

	public Text temp;
	public int existingCharacter;
	public int newCharacter;

	private void Awake () {
		if (PlayerPrefs.HasKey("characterName")) {
			temp.text = PlayerPrefs.GetString("characterName");
		}
	}

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseUp() {
		if(PlayerPrefs.HasKey("characterName")) {
			SceneManager.LoadScene(existingCharacter);
		}
		else {
			SceneManager.LoadScene(newCharacter);
		}
	}
}
