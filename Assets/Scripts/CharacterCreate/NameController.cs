using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NameController : MonoBehaviour {

	public GameObject nameOK;
	public Text OKNameText;
	public InputField daName;
	public float tatooScale;

	void Awake() {
		GameObject.Find("Dialogue Canvas").SetActive(false);
		GameObject.Find("PlayerTatoo").GetComponent<SpriteRenderer>().sprite = Resources.Load(GameControl.control.aumakua, typeof(Sprite)) as Sprite;
		GameObject.Find("PlayerTatoo").GetComponent<Transform>().localScale = new Vector3(tatooScale, tatooScale, tatooScale);
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void promptOK() {
		nameOK.SetActive(true);
		OKNameText.text = "Are you sure " + daName.text + " is okay?";
	}

	public void Aole () {
		GameObject.Find("Dialogue Canvas").SetActive(false);
	}

	public void Ae () {
		SceneManager.LoadScene(5);
		GameControl.control.daName = daName.text;
		GameControl.control.age = 1f;
		GameControl.control.level = "Pepe";
		GameControl.control.experience = 50f;
		GameControl.control.newCharacter = false;

		PlayerPrefs.SetString("characterName", daName.text);
	}
}
